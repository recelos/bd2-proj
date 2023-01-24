using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IUserGroupsRepository
{
  List<Group> GetGroups(int userId);
  int CheckIfOwner(int userUserId, int groupGroupId);
  string GetGroupOwnerName(int groupId);
}