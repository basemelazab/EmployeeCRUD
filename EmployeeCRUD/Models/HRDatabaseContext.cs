using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Models
{
    public class HRDatabaseContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(LocalDB)\MSSQLLocalDB;initial catalog=TestDB;integrated security =true;");
        }
    }
}
