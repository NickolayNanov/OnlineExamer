namespace OnlineExamer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

        public ExamsService(IRepository<Exam> repository)
        {
            this.repository = repository;
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
                    });

            return allExams;
        }

        public FinalExamQuestions GetExamByYear(int year)
        {
            IExam exam = this.repository.FindBy(x => x.YearOfCreation == year);

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
            throw new System.NotImplementedException();
        }

        private static IEnumerable<QuestionViewModel> GetQuestionViewModels(IExam exam)
        {
            IEnumerable<QuestionViewModel> questions = exam.Questions.Select(q => new QuestionViewModel()
            {
                Content = q.Content,
                CorrectAnswer = q.CorrectAnswer,
                Answers = q.Answers,
                IsOpenAnswer = q.IsOpenAnswer,
            });

            return questions;
        }

        private string GetExamType(string type)
        {
            string result;

            if(type.Equals(BulgarianLanguageSpaceless))
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
    }
}
