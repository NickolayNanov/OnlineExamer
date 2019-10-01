namespace OnlineExamer.Data.Seeding
{
    using System;
    using System.Collections.Generic;

    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var seeders = new List<ISeeder>
                          {
                              new SchoolSubjectsSeeder(),
                              new ExamSeeder(),
                              new QuestionAnswerSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                seeder.Seed(context, serviceProvider);
            }
        }
    }
}
