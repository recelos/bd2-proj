using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories.Interfaces;

namespace BillSplitter.UI.Forms;

public partial class FormAddUserToGroup : Form
{
  private readonly IAddUserToGroupRepository _repository;
  private readonly Group _group;

  public FormAddUserToGroup(Group group, 
    IAddUserToGroupRepository repository)
  {
    _group = group;
    _repository = repository;
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

    var success = _repository.AddUserToGroup(name, _group.GroupId);

    if (!success)
    {
      MessageBox.Show("Cannot add user");
    }

    Close();
  }
}