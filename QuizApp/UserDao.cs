using Microsoft.Data.SqlClient;

namespace QuizApp
{
    public class UserDao
    {
        public void NewUser(User user)
        {
            const string connectionString =
                @"Server=(localhost); " +
                "database=QuizDB;" +
                "trusted connection=true;";
        }

        public void RemoveUser(User user)
        {
            
        }

        public void RetrieveUser(User user)
        {
            
        }
    }
}