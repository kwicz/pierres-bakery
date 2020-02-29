using Bakery.Models;

namespace Bakery
{
  public class Store
  {

    public static void Main()
    {
      Printer.Welcome();
      System.Threading.Thread.Sleep(3000);
      Printer.Menu();
    }
  }
}