namespace EfeogluHırdavat.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EfeogluHırdavat.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EfeogluHırdavat.Models.EfeogluHırdavatDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EfeogluHırdavatDBModel context)
        {
            context.Brands.AddOrUpdate(x => x.ID, new Brand() { ID = 1, Name = "Crown", Logo = "crown.png" });
            context.Admins.AddOrUpdate(x => x.ID, new Admin() { ID = 1, Name = "Abdullah", Surname = "Efeoğlu", Mail = "efeoglu@gmail.com", Password = "123", IsAdmin = true, IsActive = true, IsDeleted = false });
        }
    }
}
