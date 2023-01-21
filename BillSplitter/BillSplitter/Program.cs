using BillSplitter.DataAccess.Repositories;

namespace BillSplitter
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();
      Application.Run(new FormLogin(new LoginRepository()));
    }
  }
}