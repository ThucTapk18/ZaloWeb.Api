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
            for (int i = 2; i < 10; i++)
            {
                context.Users.AddOrUpdate(new Tables.User
                {
                    Id = i,
                    Name = "Panda Cute",
                    UserName = "panda"
                });
            }
            context.Friends.AddOrUpdate(new Tables.Friend
            {
                LeftId = 1,
                RightId = 2,
                StartDate = DateTime.Now
                
            });
        }
    }
}
