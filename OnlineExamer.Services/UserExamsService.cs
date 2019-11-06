namespace OnlineExamer.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;

    public class UserExamsService : IUserExamsService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository<UserExam> repository;

        public UserExamsService(IRepository<UserExam> repository,
                                UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<MyExamViewModel>> GetExamsForUser(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);

            var exams = this.repository
                                .AllAsNoTracking(ux => ux.UserId == user.Id)
                                .Select(ux => ux.Exam)
                                .ToList();

            var userExams = this.repository
                                .AllAsNoTracking(ux => ux.UserId == user.Id)
                                .Include(x => x.Exam)
                                .Include(x => x.User)
                                .ToList();

            var userExamViewModels = userExams.Select(x =>
                                                    new MyExamViewModel()
                                                    {
                                                        Year = x.Exam.YearOfCreation,
                                                        Points = x.Points,
                                                        ExamType = x.Exam.ExamType.ToString()
                                                    });

            return userExamViewModels;
        }

        public async Task<IEnumerable<ExamViewModel>> GetExamTypesForUser(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);

            var exams = this.repository
                                .AllAsNoTracking(ux => ux.UserId == user.Id)
                                .Select(ux => ux.Exam)
                                .ToList();

            var examViewModels = exams.Select(x => new ExamViewModel()
            {
                ExamType = x.ExamType.ToString(),
                YearOfCreation = x.YearOfCreation
            }).ToList();

            return examViewModels;
        }

        public async Task<IEnumerable<MyExamViewModel>> GetSatExamsByUser(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);
            var userExams = this.repository.AllAsNoTracking(x => x.UserId == user.Id);

            var myExams = userExams.Select(x => new MyExamViewModel()
            {
                ExamType = x.Exam.ExamType.ToString(),
                Year = x.Exam.YearOfCreation,
                Points = x.Points
            }).ToList()
              .OrderBy(x => x.ExamType)
              .AsEnumerable();

            return myExams;
        }
    }
}
