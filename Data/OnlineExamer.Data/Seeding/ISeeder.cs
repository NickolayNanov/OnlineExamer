﻿namespace Examer.Data.Seeding
{
    using System;


    public interface ISeeder
    {
        void Seed(OnlineExamerDbContext context, IServiceProvider serviceProvider);
    }
}
