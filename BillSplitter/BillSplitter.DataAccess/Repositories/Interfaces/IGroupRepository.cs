using BillSplitter.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter.DataAccess.Repositories.Interfaces
{
  public interface IGroupRepository
  {
    List<Balance> GetUserBalances(int userId, int groupId, IReadOnlyCollection<User> otherUsers);

    List<Receipt> GetReceipts(int groupId);

    List<User> GetOtherUsers(int userId, int groupId);
  }
}
