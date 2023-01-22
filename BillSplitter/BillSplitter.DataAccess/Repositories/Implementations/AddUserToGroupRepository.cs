using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class AddUserToGroupRepository : IAddUserToGroupRepository
{
  public bool AddUserToGroup(string username, int groupId)
  {
    using var connection = ConnectionFactory.Create();

    int rowsAffected;
    try
    {
      var userId = connection.QueryFirst<User>(StoredProcedures.GetUserByUsername,
          new { user_name = username },
          commandType: System.Data.CommandType.StoredProcedure)
        .UserId;

      rowsAffected = connection.Execute(StoredProcedures.AddUserToGroup,
        new { group_id = groupId, user_id = userId });
    }
    catch (Exception)
    {
      return false;
    }

    return rowsAffected > 0;
  }
}