using System.Globalization;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

public partial class FormAddReceipt : Form
{
  private readonly User _user;
  private readonly Group _group;
  private readonly IAddReceiptRepository _repository;
  private List<UserAmount> _userAmounts;

  public FormAddReceipt(User user, Group group, 
    IReadOnlyCollection<User> users, 
    IAddReceiptRepository addReceiptRepository)
  {
    _user = user;
    _group = group;
    _repository = addReceiptRepository;

    _userAmounts = users
      .Select(x => new UserAmount
      {
        Amount = 0,
        User = x.Username,
        UserId = x.UserId
      })
      .ToList();

    InitializeComponent();
    usersDataGridView.DataSource = _userAmounts;
    usersDataGridView.Columns["UserId"].Visible = false;
  }

  private void acceptButton_Click(object sender, EventArgs e)
  {
    var temp = new List<(int, decimal)>();

    try
    {
      temp.AddRange(
        usersDataGridView
          .Rows
          .Cast<DataGridViewRow>()
        .Select(row => ((int)row.Cells["UserId"].Value, Convert.ToDecimal(row.Cells["Amount"].Value, CultureInfo.InvariantCulture))));
    }
    catch (Exception)
    {
      MessageBox.Show("Wrong data");
      return;
    }

    if (temp.Any(xd => xd.Item2 < 0) ||  string.IsNullOrEmpty(recipeNameTextBox.Text))
    {
      MessageBox.Show("Wrong data");
      return;
    }

    var amount = GetWholeAmount(temp);
    var title = recipeNameTextBox.Text;

    var receiptId = _repository.TryAddReceipt(_user.UserId, _group.GroupId, amount, title);

    if (receiptId == -1)
    {
      MessageBox.Show("Error when adding receipt");
      return;
    }

    foreach (var tuple in temp.Where(tuple => tuple.Item2 != 0))
    {
      _repository.AddUserToReceipt(tuple.Item1, receiptId, tuple.Item2);
    }

    Close();
  }

  private static decimal GetWholeAmount(List<(int, decimal)> temp)
  {
    return temp.Sum(x => x.Item2);
  }
}