using BillSplitter.DataAccess.Consts;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using Dapper;

namespace BillSplitter.DataAccess.Repositories.Implementations
{
    public class GroupRepository : IGroupRepository
    {
        public List<Balance> GetUserBalances(int groupId, int userId)
        {
            return new List<Balance>();
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

        public List<User> GetOtherUsers(int userId ,int groupId)
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
