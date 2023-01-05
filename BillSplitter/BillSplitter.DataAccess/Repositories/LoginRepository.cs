using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Enums;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

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

            var output = conn
                .Query<string>(StoredProcedures.GetUsersPassword, new 
                {
                    user_name = login 
                },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();

            return output;
        }
    }
}