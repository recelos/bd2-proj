using System.Data;
using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class UserGroupsRepository : IUserGroupsRepository
{
  public List<Group> GetGroups(int userId)
  {
    using var connection = ConnectionFactory.Create();

    return connection.Query<Group>(
        StoredProcedures.GetUsersGroups,
        new { user_id = userId },
        commandType: System.Data.CommandType.StoredProcedure)
      .AsList();
  }

  public int CheckIfOwner(int userId, int groupId)
  {
    using var connection = ConnectionFactory.Create();

    return connection.QueryFirst<int>(StoredProcedures.CheckIfOwner,
      new { user_id = userId, group_id = groupId },
      commandType: CommandType.StoredProcedure);
  }
}