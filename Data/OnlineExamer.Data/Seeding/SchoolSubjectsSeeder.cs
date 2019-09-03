namespace Examer.Data.Seeding
{
    using System;
    using System.Linq;

    using OnlineExamer.Domain;

    class SchoolSubjectsSeeder : ISeeder
    {
        public void Seed(OnlineExamerDbContext context, IServiceProvider serviceProvider)
        {
            if (!context.SchoolSubjects.Any())
            {
                SchoolSubject[] schoolSubjects = new[]
                {
                new SchoolSubject{Name = "Biology"},
                new SchoolSubject{Name = "Chemistry"},
                new SchoolSubject{Name = "History"},
                new SchoolSubject{Name = "Math"},
                new SchoolSubject{Name = "Geography"},
                new SchoolSubject{Name = "English"},
                new SchoolSubject{Name = "Psychology"},
            };

                context.SchoolSubjects.AddRange(schoolSubjects);
                context.SaveChanges();
            }
        }
    }
}
