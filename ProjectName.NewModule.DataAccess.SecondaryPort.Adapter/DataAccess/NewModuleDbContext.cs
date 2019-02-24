using System.Data.Entity;
using $ext_ApplicationName$.$ext_NewModuleName$.Entities;

namespace $ext_ApplicationName$.$ext_NewModuleName$.DataAccess.SecondaryPort.Adapter.DataAccess
{
    public class $ext_NewModuleName$DbContext: DbContext
    {
        internal DbSet<DummyEntity> Dummies { get; set; }

        public $ext_NewModuleName$DbContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DummyEntity>()
                .HasKey(entity => entity.Id);
        }
    }
}