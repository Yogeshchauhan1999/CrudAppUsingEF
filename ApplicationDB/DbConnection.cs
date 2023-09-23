using Microsoft.EntityFrameworkCore;
using TestApplication.Models;

namespace TestApplication.ApplicationDB
{
    public class DbConnection:DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options)
        {

        }

        public DbSet<EmployeeData> EmployeeDatas { get; set; }
        public IEnumerable<object> User { get; internal set; }
    }
}
