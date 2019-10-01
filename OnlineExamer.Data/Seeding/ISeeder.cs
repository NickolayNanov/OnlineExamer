namespace OnlineExamer.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        void Seed(ApplicationDbContext context, IServiceProvider serviceProvider);
    }
}
