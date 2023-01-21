using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories;
using BillSplitter.DataAccess.Repositories.Implementations;

namespace BillSplitter.UI.Forms
{
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

      _groups = _repository.GetGroups(_user.UserId);

      groupsDataGrid.DataSource = _groups;
    }

    private void groupsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var groupId = (int)groupsDataGrid.Rows[e.RowIndex].Cells[0].Value;


      var group = _groups.Where(x => x.group_id == groupId).FirstOrDefault();


      new FormGroup(_user, group, new GroupRepository())
          .ShowDialog();
    }
  }
}
