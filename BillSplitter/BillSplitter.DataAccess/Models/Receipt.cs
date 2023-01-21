using System;
using System.ComponentModel;

namespace BillSplitter.DataAccess.Models
{
  public class Receipt
  {
    // [Browsable(false)]
    public int ReceiptId { get; set; }
    public string Name { get; set; }
    public string Paying { get; set; }
    public decimal Amount { get; set; }

    public DateTime Date { get; set; }
  }
}
