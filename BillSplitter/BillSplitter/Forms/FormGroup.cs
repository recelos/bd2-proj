using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories;
using BillSplitter.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillSplitter.UI.Forms
{
  public partial class FormGroup : Form
  {
    private readonly User _user;
    private readonly Group _group;

    private List<User> _otherUsers;

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

      billsGridView.DataSource = _repository.GetReceipts(_group.group_id);
      // balanceGridView.DataSource = _repository.GetUserBalances(int userId, int groupId);
    }
  }
}
