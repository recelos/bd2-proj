using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations;

public class UserGroupsRepository : IUserGroupsRepository
{
    public List<Group> GetGroups(int userId)
    {
        using var conn = ConnectionFactory.Create();

        return conn.Query<Group>(
            StoredProcedures.GetUsersGroups,
            new { user_id = userId },
            commandType: System.Data.CommandType.StoredProcedure)
          .AsList();
    }
}