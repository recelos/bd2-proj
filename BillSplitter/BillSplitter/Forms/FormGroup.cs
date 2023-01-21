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

    groupLabel.Text = _group.name;


    _otherUsers = _repository.GetOtherUsers(_user.UserId, _group.group_id);
    _receipts = _repository.GetReceipts(_group.group_id);


    billsGridView.DataSource = _receipts;
    balanceGridView.DataSource = _repository.GetUserBalances(_user.UserId, _group.group_id, _otherUsers);

    billsGridView.Columns["ReceiptId"].Visible = false;
  }

  private void billsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    var id = (int)billsGridView.Rows[e.RowIndex].Cells[0].Value;

    var receipt = _receipts.First(x => x.ReceiptId == id);

    new FormReceiptDetails(receipt, new ReceiptDetailsRepository()).Show();
  }
}