using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;
using BillSplitter.DataAccess.Repositories.Implementations;

namespace BillSplitter.UI.Forms;

public partial class FormGroupOwner : Form
{
  private readonly User _user;
  private readonly Group _group;

  private List<User> _otherUsers;
  private List<Receipt> _receipts;

  private readonly IGroupOwnerRepository _repository;

  public FormGroupOwner(
    User user,
    Group group,
    IGroupOwnerRepository repository)
  {
    InitializeComponent();
    _user = user;
    _group = group;
    _repository = repository;

    groupLabel.Text = _group.Name;
    userLabel.Text = $"{_user.FirstName} {_user.LastName}";

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
    new FormAddReceipt(_user, _group, _otherUsers, new AddReceiptRepository())
      .ShowDialog();
    ReloadResources();
  }
  private void addUserButton_Click(object sender, EventArgs e)
  {
    new FormAddUserToGroup(_group, new AddUserToGroupRepository())
      .ShowDialog();
    ReloadResources();
  }

  private void ReloadResources()
  {
    groupLabel.Text = _group.Name;


    _otherUsers = _repository.GetOtherUsers(_user.UserId, _group.GroupId);
    _receipts = _repository.GetReceipts(_group.GroupId);


    billsGridView.DataSource = _receipts;
    balanceGridView.DataSource = _repository.GetUserBalances(_user.UserId, _group.GroupId, _otherUsers);

    billsGridView.Columns["ReceiptId"].Visible = false;
  }

  private void deleteButton_Click(object sender, EventArgs e)
  {
    var confirmed = MessageBox.Show("Do you really want to delete this receipt?", "Delete receipt" , MessageBoxButtons.YesNo);

    if (confirmed == DialogResult.No)
    {
      return;
    }

    var receiptId = (int)billsGridView.SelectedRows[0].Cells[0].Value;

    var success = _repository.DeleteReceipt(receiptId);

    MessageBox.Show(success ? "Receipt delete successfully" : "Can't delete receipt");

    ReloadResources();
  }
}