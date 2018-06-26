using System;
using System.Windows.Forms;

namespace tic_tac_toe
{
  static class Program
  {
   
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new TicTacToeGUI());
    }
  }
}
