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





    }
}