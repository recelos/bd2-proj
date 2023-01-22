using BillSplitter.DataAccess.Enums;
using BillSplitter.DataAccess.Repositories;
using BillSplitter.DataAccess.Repositories.Implementations;
using BillSplitter.DataAccess.Repositories.Interfaces;
using BillSplitter.UI.Forms;

namespace BillSplitter;

public partial class FormLogin : Form
{
  private readonly ILoginRepository _repository;
  public FormLogin(ILoginRepository repository)
  {
    InitializeComponent();
    _repository = repository;
  }

  private void loginButton_Click(object sender, EventArgs e)
  {
    var username = loginTextBox.Text;
    var password = passwordTextBox.Text;

    var result = _repository.TryToLogin(username, password);


    switch (result)
    {
      case LoginResult.Ok:
        this.Hide();
        var user = _repository.GetUserByUserName(username);
        new FormUserGroups(new UserGroupsRepository(), user).ShowDialog();
        this.Close();
        break;
      case LoginResult.ConnectionError:
        MessageBox.Show("Connection error");
        break;
      case LoginResult.WrongCredentials:
        MessageBox.Show("Wrong credentials");
        break;
      default:
        break;

    }
  }
}