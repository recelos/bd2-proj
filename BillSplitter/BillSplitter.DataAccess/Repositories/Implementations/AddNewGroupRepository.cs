using System;
using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations
{
  public class AddNewGroupRepository : IAddNewGroupRepository
  {
    public bool TryAddGroup(int userId, string groupName)
    {
      using var connection = ConnectionFactory.Create();

      try
      {
        connection.Execute(StoredProcedures.AddNewGroup,
          new { owner_id = userId, group_name = groupName },
          commandType: System.Data.CommandType.StoredProcedure);

      }
      catch (Exception)
      {
        return false;
      }

      return true;
    }
  }
}
