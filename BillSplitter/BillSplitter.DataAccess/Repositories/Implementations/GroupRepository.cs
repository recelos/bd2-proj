using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations
{
  public class GroupRepository : IGroupRepository
  {
    public List<Balance> GetUserBalances(int userId, int groupId, IReadOnlyCollection<User> otherUsers)
    {
      using var connection = ConnectionFactory.Create();

      var output = new List<Balance>();

      foreach(var otherUser in otherUsers)
      {
        var balance = new Balance();

        var otherUsersDebt = connection
          .Query<decimal>(StoredProcedures.GetUserDebt,
            new { group_id = groupId, user_id = userId, owning_user_id = otherUser.UserId },
            commandType: System.Data.CommandType.StoredProcedure)
          .FirstOrDefault();


        var thisUsersDebt = connection
          .Query<decimal>(StoredProcedures.GetUserDebt,
            new { group_id = groupId, user_id = otherUser.UserId, owning_user_id = userId },
            commandType: System.Data.CommandType.StoredProcedure)
          .FirstOrDefault();

        balance.Name = otherUser.Username;
        balance.Amount = otherUsersDebt - thisUsersDebt;

        output.Add(balance);
      }

      return output;
    }

    public List<Receipt> GetReceipts(int groupId)
    {
      using var connection = ConnectionFactory.Create();

      return connection
          .Query<Receipt>(StoredProcedures.GetReceiptsInGroup,
          new { group_id = groupId },
          commandType: System.Data.CommandType.StoredProcedure)
          .AsList();
    }

    public List<User> GetOtherUsers(int userId, int groupId)
    {
      using var connection = ConnectionFactory.Create();
      var users = connection
          .Query<User>(StoredProcedures.GetUsersInGroup,
          new { group_id = groupId },
          commandType: System.Data.CommandType.StoredProcedure)
          .AsList();

      return users
          .Where(x => x.UserId != userId)
          .AsList();
    }
  }
}
