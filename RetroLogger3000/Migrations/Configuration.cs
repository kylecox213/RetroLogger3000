namespace RetroLogger3000.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RetroLogger3000.DAL.RetroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RetroLogger3000.DAL.RetroContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //
            //    context.RetroGame.AddOrUpdate(
            //       r => r.Title,
            //       new RetroGame { Title = "Robocop" },
            //       new RetroGame { Title = "Air Fortress" },
            //       new RetroGame { Title = "Dig Dug II" }
            //    );
        }
    }
}
