using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Implementations;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

public partial class FormUserGroups : Form
{
  private readonly IUserGroupsRepository _repository;
  private readonly User _user;

  private List<Group> _groups;

  public FormUserGroups(IUserGroupsRepository repository, User user)
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


    var isOwner = _repository.CheckIfOwner(_user.UserId, group.GroupId);

    if (isOwner == 1)
    {
      new FormGroupOwner(_user, group, new GroupRepository())
        .ShowDialog();
    }
    else
    {
      new FormGroup(_user, group, new GroupRepository())
        .ShowDialog();
    }
  }

  private void addNewGroupButton_Click(object sender, EventArgs e)
  {
    new FormAddNewGroup(_user, new AddNewGroupRepository())
      .ShowDialog();
    ReloadResources();
  }


  private void ReloadResources()
  {
    _groups = _repository.GetGroups(_user.UserId);

    groupsDataGrid.DataSource = _groups;

    groupsDataGrid.Columns["GroupId"].Visible = false;
  }
}