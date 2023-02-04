using BillSplitter.DataAccess.Repositories.Implementations;
using BillSplitter.UI.Forms;

namespace BillSplitter.UI;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();
    Application.Run(new FormLogin(new LoginRepository()));
  }
}