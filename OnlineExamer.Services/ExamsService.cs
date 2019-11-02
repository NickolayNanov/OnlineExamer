namespace OnlineExamer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Data.Domain.Enums;
    using OnlineExamer.Domain;
    using OnlineExamer.Domain.Contracts;
    using OnlineExamer.Models;
    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;

    public class ExamsService : IExamsService
    {
        private const string BulgarianLanguageSpaceless = "БългарскиEзик";
        private const string BulgarianLanguage = "Български Eзик";
        private const string EnglishLanguageSpaceless = "АнглийскиЕзик";
        private const string EnglishLanguage = "Английски Език";


        private readonly IRepository<Exam> repository;
        private readonly UserManager<ApplicationUser> userManager;

        public ExamsService(IRepository<Exam> repository,
                            UserManager<ApplicationUser> userManager)
        {
            this.repository = repository;
            this.userManager = userManager;
        }

        public IEnumerable<ExamViewModel> AllExams()
        {
            var allExams = this.repository
                .AllAsNoTracking(x => x != null)
                .Select(x =>
                    new ExamViewModel()
                    {
                        ExamType = x.ExamType.ToString(),
                        YearOfCreation = x.YearOfCreation,
                    })
                .ToList();

            return allExams;
        }

        public FinalExamQuestions GetExamByYear(int year)
        {
            IExam exam = this.repository.FirstOrDefault(x => x.YearOfCreation == year);

            FinalExamQuestions model = new FinalExamQuestions
            {
                ExamType = exam.ExamType.ToString(),
                YearOfCreation = exam.YearOfCreation,
                Questions = GetQuestionViewModels(exam)
            };

            return model;
        }

        public IEnumerable<ExamViewModel> GetExamsByType(string examTypeAsString)
        {
            ExamType examType;
            bool examEnum = Enum.TryParse<ExamType>(examTypeAsString, ignoreCase: true, out examType);

            if (!examEnum)
            {
                return null;
            }

            var exams = this.repository.AllAsNoTracking(exam => exam.ExamType == examType);
            var examsAsViewModels = exams
                .Select(x => new ExamViewModel()
                {
                    ExamType = x.ExamType.ToString(),
                    YearOfCreation = x.YearOfCreation,
                })
                .ToList();

            return examsAsViewModels;
        }

        public IEnumerable<ExamViewModel> MyExams()
        {
            throw new NotImplementedException();
        }

        private static IList<QuestionViewModel> GetQuestionViewModels(IExam exam)
        {
            IList<QuestionViewModel> questions = exam.Questions.Select(q => new QuestionViewModel()
            {
                Content = q.Content,
                CorrectAnswer = 1,
                Answers = q.Answers.Select(a => new AnswerViewModel() { Content = a.Content }).ToList(),
                IsOpenAnswer = q.IsOpenAnswer,
            }).ToList();

            return questions;
        }

        private string GetExamType(string type)
        {
            string result;

            if (type.Equals(BulgarianLanguageSpaceless))
            {
                result = BulgarianLanguage;
            }
            else if (type.Equals(EnglishLanguageSpaceless))
            {
                result = EnglishLanguage;
            }
            else
            {
                result = type;
            }

            return result;
        }

        public async Task<int> SolveExam(ExamQuestions examQuestion, string name)
        {
            var exam = this.repository.FirstOrDefault(exam => exam.YearOfCreation == examQuestion.YearOfCreation);

            int points = 0;

            for (int i = 0; i < exam.Questions.Count; i++)
            {
                int correct = exam.Questions[i].CorrectAnswer - 1;
                var answer = examQuestion?.Questions[i].Answers.Where(a => a.IsSelected == true).FirstOrDefault();
                int actual = Array.IndexOf(examQuestion.Questions[i].Answers.ToArray(), answer);

                if (correct == actual)
                {
                    points++;
                }
            }

            var user = await this.userManager.FindByNameAsync(name);

            UserExam userExam = new UserExam() { ExamId = exam.Id, UserId = user.Id };

            if (user.UserExams.FirstOrDefault(x => x.UserId == user.Id) == null && user.UserExams.FirstOrDefault(x => x.ExamId == exam.Id) == null)
            {
                userExam = new UserExam() { ExamId = exam.Id, UserId = user.Id };

                user.UserExams.Add(userExam);
                await this.repository.SaveChangesAsync();
            }
            else if (user.UserExams.FirstOrDefault(x => x.UserId == user.Id) != null && user.UserExams.FirstOrDefault(x => x.ExamId == exam.Id) != null)
            {
                userExam.Points = Math.Max(userExam.Points, points);
                var userExamFromDb = user.UserExams.FirstOrDefault(x => x.UserId == user.Id && x.ExamId == exam.Id);
                userExamFromDb.Points = Math.Max(points, userExamFromDb.Points);
                await this.repository.SaveChangesAsync();
            }

            return points;
        }

        public IEnumerable<ExamViewModel> GetExamsForUser(string name)
        {
            return null;
        }
    }
}
