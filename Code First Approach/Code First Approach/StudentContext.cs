using Code_First_Approach.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Approach
{
    public class StudentContext : DbContext
    {
        public StudentContext():base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext, Configuration>());
        }
        public DbSet<Student> students { get; set; }

        public DbSet<Department> departments { get; set; }

    }
}
