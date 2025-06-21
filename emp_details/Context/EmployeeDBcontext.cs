using Microsoft.EntityFrameworkCore;
using emp_details.Models;


namespace emp_details.Context
{
    public class EmployeeDBcontext:DbContext
    {

        public EmployeeDBcontext(DbContextOptions options):base(options) { 
        }

        public DbSet <Employee>  Employees { get; set; }
    }
}
