namespace BillSplitter.DataAccess.Models;

public class Balance
{
  public int OtherUserId { get; set; }
  public string Name { get; set; }

  public decimal Amount { get; set; }
}