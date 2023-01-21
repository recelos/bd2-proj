using System.ComponentModel;

namespace BillSplitter.DataAccess.Models
{
  public class Group
  {
    public int group_id { get; set; }
    public string name { get; set; }
    [Browsable(false)]
    public int owner_id { get; set; }
  }
}
