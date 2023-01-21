using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class ReceiptDetailsRepository : IReceiptDetailsRepository
{
  public List<UserReceiptDetail> GetUsersInReceipt(Receipt receipt)
  {
    using var connection = ConnectionFactory.Create();

    return connection.Query<UserReceiptDetail>(
        StoredProcedures.GetUsersInReceipt,
        new { receipt_id = receipt.ReceiptId },
        commandType: System.Data.CommandType.StoredProcedure)
      .AsList();
  }
}