namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IAddUserToGroupRepository
{
  bool AddUserToGroup(string username, int groupId);
}