using Microsoft.EntityFrameworkCore;
namespace QuizApp.DbModels
{
    public class QuizContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LeaderBoard> LeaderBoards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb\MSSQLLocalDB; )" +
                                        "Database = QuizDB " +
                                        "Trusted_Connection = True;");
        }
    }
}