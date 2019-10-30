namespace OnlineExamer.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OnlineExamer.Domain;

    public class QuestionAnswerSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            if (!context.Questions.Any())
            {
                Question[] questions =
                {
                    new Question()
                    {
                        CorrectAnswer = 1,
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("ASDASDSADASD"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                        }
                    },
                    new Question()
                    {
                        CorrectAnswer = 1,
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("asdasdasdsad"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                        }
                    },
                    new Question()
                    {
                        CorrectAnswer = 1,
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("asdasdasdasd"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                        }
                    },
                    new Question()
                    {
                        CorrectAnswer = 1,
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("asdsadasdsad"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                            new Answer("ьяаяьаьяаяьа"),
                        }
                    },
                };

                context.Questions.AddRange(questions);
                context.SaveChanges();

                Answer answer = context.Answers.FirstOrDefault();

                foreach (var question in context.Questions)
                {
                    question.CorrectAnswer = 1;
                }

                context.SaveChanges();
            }
        }
    }
}
