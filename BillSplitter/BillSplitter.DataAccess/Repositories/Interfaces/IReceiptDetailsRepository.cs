using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces;

public interface IReceiptDetailsRepository
{
  public List<UserReceiptDetail> GetUsersInReceipt(Receipt receipt);
}