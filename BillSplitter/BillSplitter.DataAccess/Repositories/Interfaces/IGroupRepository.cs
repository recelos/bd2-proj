using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IGroupRepository
{
  List<Balance> GetUserBalances(int userId, int groupId, IReadOnlyCollection<User> otherUsers);

  List<Receipt> GetReceipts(int groupId);

  List<User> GetOtherUsers(int userId, int groupId);
}