namespace BillSplitter.DataAccess.Models;

public class UserAmount
{
  public int UserId { get; set; }
  public string User { get; set; }

  public decimal Amount { get; set; }
}