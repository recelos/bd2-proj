using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Enums;
using MySqlConnector;

namespace BillSplitter.DataAccess.Repositories
{
    public class LoginRepository
    {
        public LoginResult TryToLogin(string login, string password)
        {

            string? retrievedPassword;
            try
            {
                retrievedPassword = GetUserPassword(login);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return LoginResult.ConnectionError;
            }

            if(retrievedPassword is null)
            {
                return LoginResult.WrongCredentials;
            }

            if (retrievedPassword.Equals(password))
            {
                return LoginResult.Ok;
            }


            return LoginResult.WrongCredentials;
        }

        private static string GetUserPassword(string login)
        {
            using var conn = ConnectionFactory.Create();
            using var cmd = new MySqlCommand(StoredProcedures.GetUsersPassword, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user_name", login);

            conn.Open();

            var output = cmd.ExecuteScalar() as string;
            conn.Close();

            return output;
        }
    }
}