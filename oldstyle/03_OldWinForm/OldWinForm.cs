// CalendarItemViewer.cs
// ./日付フォルダ/yyyymmdd のファイルリストを表示する。
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace OldWinForm {
  class OldWinForm
  {
    static void Main()
    {
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
      this.Text = "Old WinForms Sample";
    }
  }
}