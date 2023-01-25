using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using BillSplitter.DataAccess.Repositories.Implementations;

namespace BillSplitter.UI.Forms;

public partial class FormGroup : Form
{
  private readonly User _user;
  private readonly Group _group;

  private List<User> _otherUsers;
  private List<Receipt> _receipts;

  private readonly IGroupRepository _repository;

  public FormGroup(
    User user,
    Group group,
    IGroupRepository repository)
  {
    InitializeComponent();
    _user = user;
    _group = group;
    _repository = repository;

    groupLabel.Text = _group.Name;
    userLabel.Text = $"{_user.FirstName} {_user.LastName}" ;
    ownerLabel.Text = _group.OwnerName;

    ReloadResources();
  }

  private void billsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    var id = (int)billsGridView.Rows[e.RowIndex].Cells[0].Value;

    var receipt = _receipts.First(x => x.ReceiptId == id);

    new FormReceiptDetails(receipt, new ReceiptDetailsRepository()).Show();
  }

  private void addReceiptButton_Click(object sender, EventArgs e)
  {
    new FormAddReceipt(_user, _group, _otherUsers, new AddReceiptRepository()).ShowDialog();
    ReloadResources();
  }

  private void ReloadResources()
  {
    groupLabel.Text = _group.Name;


    _otherUsers = _repository.GetOtherUsers(_user.UserId, _group.GroupId);
    _receipts = _repository.GetReceipts(_group.GroupId);


    billsGridView.DataSource = _receipts;
    balanceGridView.DataSource = _repository.GetUserBalances(_user.UserId, _group.GroupId, _otherUsers);

    billsGridView.Columns["ReceiptId"]!.Visible = false;
    balanceGridView.Columns["OtherUserId"]!.Visible = false;
  }

  private void leaveButton_Click(object sender, EventArgs e)
  {
    var dialogResult = MessageBox.Show($"Do you really want to leave this group?",
      "Leave group", MessageBoxButtons.YesNo);

    if (dialogResult == DialogResult.No)
    {
      return;
    }

    _repository.DeleteUser(_user.UserId, _group.GroupId);

    Close();
  }
}