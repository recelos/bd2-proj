using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IGroupOwnerRepository
{
  List<Balance> GetUserBalances(int userId, int groupId, IReadOnlyCollection<User> otherUsers);

  List<Receipt> GetReceipts(int groupId);

  List<User> GetOtherUsers(int userId, int groupId);

  bool DeleteReceipt(int receiptId);

  bool DeleteUser(int userId, int groupId);

  void DeleteGroup(int groupId);
}