using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Enums;
using System.Data;
using Dapper;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using System.Security.Cryptography;

namespace BillSplitter.DataAccess.Repositories.Implementations;
public class LoginRepository : ILoginRepository
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

    if (retrievedPassword.Equals(HashPassword(password)))
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
  
  public string HashPassword(string password)
  {
    using (SHA256 sha256 = SHA256.Create())
    {
      byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
      return BitConverter.ToString(bytes).Replace("-", "").ToLower();
    }
  }
}