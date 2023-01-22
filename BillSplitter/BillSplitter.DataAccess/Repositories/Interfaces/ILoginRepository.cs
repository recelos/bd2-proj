using BillSplitter.DataAccess.Enums;
using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface ILoginRepository
{
  public LoginResult TryToLogin(string login, string password);
  public User? GetUserByUserName(string login);
}