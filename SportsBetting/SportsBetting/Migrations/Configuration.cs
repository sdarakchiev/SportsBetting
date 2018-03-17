namespace SportsBetting.Migrations
{
    using SportsBetting.DbModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsBetting.Data.SportsBettingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsBetting.Data.SportsBettingContext context)
        {
            context.Events.AddOrUpdate(new Event()
            {
                EventName = "Liverpool - Juventus",
                OddsForFirstTeam = 1.95,
                OddsForDraw = 3.15,
                OddsForSecondTeam = 2.20,
                EventStartDate = DateTime.Now
            },
            new Event()
            {
                EventName = "Grigor Dimitrov - Rafael Nadal",
                OddsForFirstTeam = 2.00,
                OddsForDraw = 3.05,
                OddsForSecondTeam = 2.17,
                EventStartDate = DateTime.Now
            },
            new Event()
            {
                EventName = "Barcelona - Ludogorets",
                OddsForFirstTeam = 1.01,
                OddsForDraw = 4.20,
                OddsForSecondTeam = 15.20,
                EventStartDate = DateTime.Now
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
