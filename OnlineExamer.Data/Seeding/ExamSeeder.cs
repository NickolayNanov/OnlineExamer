namespace OnlineExamer.Data.Seeding
{
    using System;
    using System.Linq;
    using OnlineExamer.Data.Domain.Enums;
    using OnlineExamer.Domain;

    public class ExamSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            if (!context.Exams.Any())
            {
                Exam[] exams =
                {
                    new OrdinaryExam(){ ExamType = ExamType.БългарскиEзик},
                    new OrdinaryExam(){ ExamType = ExamType.Биология},
                    new OrdinaryExam(){ ExamType = ExamType.География},
                    new OrdinaryExam(){ ExamType = ExamType.Психология},
                    new FinalExam(){ ExamType = ExamType.История},
                    new FinalExam(){ ExamType = ExamType.Математика},
                };

                context.Exams.AddRange(exams);
                context.SaveChanges();
            }
        }
    }
}
