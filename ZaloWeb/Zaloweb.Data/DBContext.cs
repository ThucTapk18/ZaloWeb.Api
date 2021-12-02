using Zaloweb.Data.Tables;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Zaloweb.Data
{
    public partial class DBContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }

        public DBContext() : base("Server=localhost:DESKTOP-MUSSU0N; Database=ZaloWeb") { }
        public DBContext(string connString) : base(connString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}
