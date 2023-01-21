using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using Dapper;

namespace BillSplitter.DataAccess.Repositories
{
  public class UserGroupsRepository
  {
    public List<Group> GetGroups(int user_id)
    {
      using var conn = ConnectionFactory.Create();

      return conn.Query<Group>(
          StoredProcedures.GetUsersGroups,
          new { user_id },
          commandType: System.Data.CommandType.StoredProcedure)
          .AsList();
    }
  }
}
