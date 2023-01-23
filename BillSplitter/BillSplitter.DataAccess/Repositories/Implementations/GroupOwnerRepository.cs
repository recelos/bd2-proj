using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class GroupOwnerRepository : GroupRepository, IGroupOwnerRepository
{
  public bool DeleteReceipt(int receiptId)
  {
    using var connection = ConnectionFactory.Create();

    var rowsAffected = connection.Execute(StoredProcedures.RemoveReceiptFromGroup,
      new { receipt_id = receiptId },
      commandType: System.Data.CommandType.StoredProcedure);

    return rowsAffected > 0;
  }
}