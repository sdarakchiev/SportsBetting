namespace SportsBetting.Migrations
{
    using SportsBetting.DbModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
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
                EventStartDate = new DateTime(2018, 12, 25, 22, 00, 00).ToString("g", DateTimeFormatInfo.InvariantInfo)
            },
            new Event()
            {
                EventName = "Grigor Dimitrov - Rafael Nadal",
                OddsForFirstTeam = 2.00,
                OddsForDraw = 3.05,
                OddsForSecondTeam = 2.17,
                EventStartDate = new DateTime(2018, 06, 06, 19, 00, 00).ToString("g", DateTimeFormatInfo.InvariantInfo)
            },
            new Event()
            {
                EventName = "Barcelona - Ludogorets",
                OddsForFirstTeam = 1.01,
                OddsForDraw = 4.20,
                OddsForSecondTeam = 15.20,
                EventStartDate = new DateTime(1055, 12, 31, 18, 30, 00).ToString("g", DateTimeFormatInfo.InvariantInfo)
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
