using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace OldWinForm {
  class OldWinForm
  {
    static void Main()
    {
#if DEBUG_CONFIG
    Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
    Debug.WriteLine("Debug Message Output: Start.");
#endif
      Application.Run(new MainWindow());
    }
  }

  class MainWindow : Form
  {
    public MainWindow()
    {
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Width = 450;
      this.Height = 300;
      this.Text = "Old WinForm Sample";
      Debug.Print("Debug Message.");
    }
  }
}