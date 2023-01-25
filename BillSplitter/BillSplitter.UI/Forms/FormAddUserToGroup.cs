using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

public partial class FormAddUserToGroup : Form
{
  private readonly IAddUserToGroupRepository _repository;
  private readonly Group _group;
  private readonly List<User> _otherUsers;

  public FormAddUserToGroup(Group group, 
    IAddUserToGroupRepository repository, 
    List<User> otherUsers)
  {
    _group = group;
    _repository = repository;
    _otherUsers = otherUsers;
    InitializeComponent();
  }

  private void addButton_Click(object sender, EventArgs e)
  {
    var name = usernameTextBox.Text;
    if (string.IsNullOrEmpty(name))
    {
      MessageBox.Show("Username cannot be empty");
      return;
    }


    if (_otherUsers.Any(x => x.Username.Equals(name)))
    {
      MessageBox.Show("User is already in the group");
      return;
    }

    var success = _repository.AddUserToGroup(name, _group.GroupId);

    if (!success)
    {
      MessageBox.Show("User does not exist");
      return;
    }

    Close();
  }
}