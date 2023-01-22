using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class AddReceiptRepository : IAddReceiptRepository
{
  public int TryAddReceipt(int userId, int groupId, decimal amount, string name)
  {
    using var connection = ConnectionFactory.Create();

    int receiptId;
    try
    {
      receiptId = connection.QueryFirst<int>(StoredProcedures.AddNewReceipt,
        new { paying_user_id = userId, group_id = groupId, amount, receipt_name = name, receipt_type_id = 1},
        commandType: System.Data.CommandType.StoredProcedure);
    }
    catch (Exception e)
    {
      throw e;
    }

    return receiptId;
  }

  public bool AddUserToReceipt(int userId, int receiptId, decimal amount)
  {
    using var connection = ConnectionFactory.Create();

    try
    {
      connection.Execute(StoredProcedures.AddUserToReceipt,
        new { user_id = userId, receipt_id = receiptId, amount },
        commandType: System.Data.CommandType.StoredProcedure);
    }
    catch (Exception)
    {
      return false;
    }
    return true;
  }
}