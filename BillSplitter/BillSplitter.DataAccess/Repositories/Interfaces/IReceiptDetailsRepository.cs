using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IReceiptDetailsRepository
{
  public List<UserAmount> GetUsersInReceipt(Receipt receipt);
}