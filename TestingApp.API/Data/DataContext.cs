using Microsoft.EntityFrameworkCore;

namespace TestingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {

            
        }
    }
}