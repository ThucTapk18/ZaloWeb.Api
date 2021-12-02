namespace Zaloweb.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Zaloweb.Data.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Zaloweb.Data.DBContext context)
        {
            context.Users.AddOrUpdate(new Tables.User
            {
                Id = 1,
                Name = "Panda Cuteeeee",
                UserName = "Panda"
            });
        }
    }
}
