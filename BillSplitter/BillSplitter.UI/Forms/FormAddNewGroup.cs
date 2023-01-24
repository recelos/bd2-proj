using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

public partial class FormAddNewGroup : Form
{
  private readonly User _user;
  private readonly IAddNewGroupRepository _repository;


  public FormAddNewGroup(User user, IAddNewGroupRepository repository)
  {
    _user = user;
    _repository = repository;
    InitializeComponent();
  }

  private void acceptButton_Click(object sender, EventArgs e)
  {
    var groupName = nameTextBox.Text;

    var success = _repository.TryAddGroup(_user.UserId, groupName);

    if (success)
    {
      Close();
    }
    else
    {
      MessageBox.Show("Blad podczas dodawania grupy");
    }
  }
}