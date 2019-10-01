namespace OnlineExamer.Data.Seeding
{
    using System;
    using System.Linq;

    using OnlineExamer.Domain;

    public class SchoolSubjectsSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            if (!context.SchoolSubjects.Any())
            {
                SchoolSubject[] schoolSubjects = new[]
                {
                new SchoolSubject{Name = "Биология"},
                new SchoolSubject{Name = "История"},
                new SchoolSubject{Name = "Математика"},
                new SchoolSubject{Name = "География"},
                new SchoolSubject{Name = "Английски език"},
                new SchoolSubject{Name = "Български език"},
                new SchoolSubject{Name = "Психология"},
            };

                context.SchoolSubjects.AddRange(schoolSubjects);
                context.SaveChanges();
            }
        }
    }
}
