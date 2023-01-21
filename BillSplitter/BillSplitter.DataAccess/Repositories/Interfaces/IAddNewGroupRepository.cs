using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter.DataAccess.Repositories.Interfaces
{
  public interface IAddNewGroupRepository
  {
    public bool TryAddGroup(int userId, string groupName);
  }
}
