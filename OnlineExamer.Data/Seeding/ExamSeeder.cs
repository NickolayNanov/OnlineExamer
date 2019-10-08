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
                    new OrdinaryExam(){ ExamType = ExamType.БългарскиEзик, YearOfCreation = 2016},
                    new FinalExam(){ ExamType = ExamType.Математика, YearOfCreation = 2017},
                    new OrdinaryExam(){ ExamType = ExamType.АнглийскиEзик, YearOfCreation = 2014},
                    new FinalExam(){ ExamType = ExamType.География, YearOfCreation = 2015},
                    new OrdinaryExam(){ ExamType = ExamType.История, YearOfCreation = 2017},
                    new FinalExam(){ ExamType = ExamType.Психология, YearOfCreation = 2019},
                    new OrdinaryExam(){ ExamType = ExamType.Биология, YearOfCreation = 2013},
                    new FinalExam(){ ExamType = ExamType.Математика, YearOfCreation = 2018},
                };

                context.Exams.AddRange(exams);
                context.SaveChanges();
            }
        }
    }
}
