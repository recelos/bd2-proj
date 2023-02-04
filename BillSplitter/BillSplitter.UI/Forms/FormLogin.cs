using System.Diagnostics;
using BillSplitter.DataAccess.Enums;
using BillSplitter.DataAccess.Repositories.Implementations;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

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
    }
  }

  private void newAccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    var psInfo = new ProcessStartInfo
    {
      FileName = "http://www.craksys.pl",
      UseShellExecute = true
    };
    Process.Start(psInfo);
  }
}