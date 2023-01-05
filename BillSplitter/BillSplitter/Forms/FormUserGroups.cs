using BillSplitter.DataAccess.Models;
using BillSplitter.DataAccess.Repositories;

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

            usernameLabel.Text = $"{user.first_name} {user.last_name}";

            _groups = _repository.GetGroups(_user.user_id);

            groupsDataGrid.DataSource = _groups;
        }
    }
}
