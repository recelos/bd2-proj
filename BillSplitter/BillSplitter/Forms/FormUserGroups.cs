using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories;
using BillSplitter.DataAccess.Repositories.Implementations;

namespace BillSplitter.UI.Forms;

public partial class FormUserGroups : Form
{
  private readonly UserGroupsRepository _repository;
  private readonly User _user;

  private List<Group> _groups;

  public FormUserGroups(UserGroupsRepository repository, User user)
  {
    InitializeComponent();
    _repository = repository;
    _user = user;

    usernameLabel.Text = $"{user.FirstName} {user.LastName}";

    ReloadResources();
  }

  private void groupsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    var groupId = (int)groupsDataGrid.Rows[e.RowIndex].Cells[0].Value;
    var group = _groups.FirstOrDefault(x => x.GroupId == groupId);

    new FormGroup(_user, group, new GroupRepository())
      .ShowDialog();
  }

  private void addNewGroupButton_Click(object sender, EventArgs e)
  {
    new FormAddNewGroup(_user, new AddNewGroupRepository()).ShowDialog();
    ReloadResources();
  }


  private void ReloadResources()
  {
    _groups = _repository.GetGroups(_user.UserId);

    groupsDataGrid.DataSource = _groups;

    groupsDataGrid.Columns["GroupId"].Visible = false;
  }
}