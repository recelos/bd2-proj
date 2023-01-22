using BillSplitter.DataAccess.Repositories.Implementations;

namespace BillSplitter;

internal static class Program
{
  [STAThread]
  static void Main()
  {
    ApplicationConfiguration.Initialize();
    Application.Run(new FormLogin(new LoginRepository()));
  }
}