using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.DAL
{
    public class PSContext : DbContext
    {
        public PSContext() : base("PSModern2")
        {
            Database.SetInitializer<PSContext>(new CreateDatabaseIfNotExists<PSContext>());
        }

        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<ResType> ResTypes { get; set; }
        public DbSet<BN> BNs { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<PS> PSs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
