using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms
{
  public partial class FormReceiptDetails : Form
  {
    private readonly Receipt _receipt;
    private readonly IReceiptDetailsRepository _repository;

    public FormReceiptDetails(Receipt receipt, IReceiptDetailsRepository repository)
    {
      _receipt = receipt;
      _repository = repository;

      InitializeComponent();

      amountLabel.Text = $"Amount: {_receipt.Amount}";
      dateLabel.Text = $"Date: {_receipt.Date}";
      nameLabel.Text = _receipt.Name;
      payerLabel.Text = _receipt.Paying;

      usersDataGridView.DataSource = _repository.GetUsersInReceipt(receipt);

    }
  }
}
