using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Enums;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using BillSplitter.DataAccess.Models;

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
      catch (Exception e)
      {
        Console.WriteLine(e);
        return LoginResult.ConnectionError;
      }

      if (retrievedPassword is null)
      {
        return LoginResult.WrongCredentials;
      }

      if (retrievedPassword.Equals(password))
      {
        return LoginResult.Ok;
      }

      return LoginResult.WrongCredentials;
    }

    public User? GetUserByUserName(string login)
    {
      using var connection = ConnectionFactory.Create();

      return connection.Query<User>(
          StoredProcedures.GetUserByUsername,
          new { user_name = login },
          commandType: CommandType.StoredProcedure)
          .FirstOrDefault();
    }

    private static string? GetUserPassword(string login)
    {
      using var connection = ConnectionFactory.Create();

      return connection.Query<string>(
          StoredProcedures.GetUsersPassword,
          new { user_name = login },
          commandType: CommandType.StoredProcedure)
          .FirstOrDefault();
    }
  }
}