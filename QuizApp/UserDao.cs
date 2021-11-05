using Microsoft.Data.SqlClient;

namespace QuizApp
{
    public class UserDao
    {
        public void NewUser(User user)
        {
            const string connectionString = 
                @"Data Source = (localdb)\MSSQLLocalDB; " +
                "Database = QuizDB " +
                ""
        }

        public void RemoveUser(User user)
        {
            
        }

        public void RetrieveUser(User user)
        {
            
        }
    }
}