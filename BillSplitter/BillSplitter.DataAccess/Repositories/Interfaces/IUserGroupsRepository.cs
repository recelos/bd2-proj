using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IUserGroupsRepository
{
  public List<Group> GetGroups(int userId);
}