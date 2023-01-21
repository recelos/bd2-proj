using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillSplitter.DataAccess.Models;

namespace BillSplitter.DataAccess.Repositories.Interfaces
{
  public interface IReceiptDetailsRepository
  {
    public List<UserReceiptDetail> GetUsersInReceipt(Receipt receipt);
  }
}
