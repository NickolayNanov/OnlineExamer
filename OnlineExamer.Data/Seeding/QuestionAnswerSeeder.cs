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
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("Курви бол"),
                            new Answer("Общака мадафака"),
                            new Answer("Общака мадафака"),
                            new Answer("Общака мадафака"),
                        }
                    },
                    new Question()
                    {
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("Курви в мол"),
                            new Answer("Общака кака мадафака"),
                            new Answer("Общака кака мадафака"),
                            new Answer("Общака кака мадафака"),
                        }
                    },
                    new Question()
                    {
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("Курви ьяаья бол"),
                            new Answer("Курви ьяаья бол"),
                            new Answer("Курви ьяаья бол"),
                            new Answer("Общака ьаяьяа мадафака"),
                        }
                    },
                    new Question()
                    {
                        ExamId = context.Exams.FirstOrDefault().Id,
                        Content = "asdasdasdas",
                        Answers = new HashSet<Answer>()
                        {
                            new Answer("Курви asdasd бол"),
                            new Answer("Общака ddasdadм адафака"),
                            new Answer("Общака ddasdadм адафака"),
                            new Answer("Общака ddasdadм адафака"),
                        }
                    },
                };

                context.Questions.AddRange(questions);
                context.SaveChanges();
            }
        }
    }
}
