namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IAddReceiptRepository
{
  int TryAddReceipt(int userId, int groupId, decimal amount, string name);
  bool AddUserToReceipt(int userId, int receiptId, decimal amount);
}