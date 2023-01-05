using BillSplitter.DataAccess.Enums;
using BillSplitter.DataAccess.Repositories;

namespace BillSplitter
{
    public partial class FormLogin : Form
    {
        private readonly LoginRepository _repository;
        public FormLogin(LoginRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var result = _repository.TryToLogin(loginTextBox.Text, passwordTextBox.Text);


            switch (result)
            {
                case LoginResult.Ok:
                    MessageBox.Show("Ok");
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
}