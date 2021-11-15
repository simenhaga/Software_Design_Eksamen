using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace QuizApp.DbModels
{
    public class QuizContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LeaderBoard> LeaderBoards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=QuizDb;user=quizAdmin;password=123456789;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new System.Version(8, 0, 22)), mySqlOptions => mySqlOptions.SchemaBehavior(MySqlSchemaBehavior.Throw));
        }
            /*optionsBuilder.UseSqlServer(@"Server=(localhost); " +
                                        "database=QuizDB;" +
                                        "trusted connection=true");*/
        }
    }
