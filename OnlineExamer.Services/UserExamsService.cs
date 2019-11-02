namespace OnlineExamer.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;

    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;

    public class UserExamsService : IUserExamsService
    {
        private readonly IRepository<UserExam> repository;
        private readonly UserManager<ApplicationUser> userManager;

        public UserExamsService(IRepository<UserExam> repository,
                                UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<MyExamViewModel>> GetExamsForUser(string user)
        {
            var userFromDb = await this.userManager.FindByNameAsync(user);

            IEnumerable<MyExamViewModel> exams = this.repository.AllAsNoTracking(x => x.UserId == userFromDb.Id)
                                                                .Select(x => x.Exam)
                                                                .Select(x => new MyExamViewModel()
                                                                {
                                                                      Year = x.YearOfCreation
                                                                })
                                                                .AsEnumerable();

            var userExams = this.repository.AllAsNoTracking(x => x.UserId == userFromDb.Id).ToList();
            
            foreach (var exam in exams)
            {
                var examm = userExams.FirstOrDefault(e => e.UserId == userFromDb.Id && e.Exam.YearOfCreation == exam.Year);
                exam.Points = examm.Points;
            }

            return null;
        }
    }
}
