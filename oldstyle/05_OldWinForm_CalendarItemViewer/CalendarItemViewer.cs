// CalendarItemViewer.cs 
// ./日付フォルダ/yyyymmdd のファイルリストを表示する。 
using System; 
using System.IO; 
using System.Drawing; 
using System.Windows.Forms; 
using System.Diagnostics;
 
class CalendarItemViewer 
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
  DateTimePicker dtp; 
  ListBox lb; 
  Timer timer; 
  public MainWindow() 
  { 
    this.StartPosition = FormStartPosition.CenterScreen; 
    this.Width = 450; 
    this.Height = 300; 
    this.Text = "./日付フォルダ/yyyymmdd のファイルリストを表示する"; 
 
    // フォームが描画された際の動作を指定する。 
    this.Shown += new EventHandler(MainWindow_Shown); 
 
    dtp = new DateTimePicker() 
    { 
      Font = new Font("ＭＳ ゴシック", 12), 
      Size = new Size(200, 20), 
      Location = new Point(10, 10), 
      Parent = this, 
    }; 
 
    // DateTimePickerの値を変更した際の動作を指定する。 
    dtp.CloseUp += new EventHandler(DateTimePicker_CloseUp); 
 
    lb = new ListBox() 
    { 
      Font = new Font("ＭＳ ゴシック", 12), 
      Size = new Size(380, 200), 
      Location = new Point(10, 40), 
      Parent = this, 
    }; 
 
    lb.SelectedIndexChanged += new EventHandler(ListBox_SelectedIndexChanged); 
  } 
 
  // フォームが描画された際の動作。 
  private void MainWindow_Shown(object sender, EventArgs e) 
  { 
    WriteListBox(sender, e); 
    timer = new Timer(); 
    timer.Interval = 5000; 
    timer.Enabled = true; 
    timer.Tick += new EventHandler(Timer_Tick); 
  } 
 
  // DateTimePickerを変更した際の動作。 
  private void DateTimePicker_CloseUp(object sender, EventArgs e) 
  { 
    WriteListBox(sender, e); 
  } 
 
  // タイマーのインターバルごとに実行する動作。 
  private void Timer_Tick(object sender, EventArgs e) 
  {   
    WriteListBox(sender, e); 
  } 
 
  // リストボックスを選択できないようにする。 
  private void ListBox_SelectedIndexChanged(object sender, EventArgs e) 
  { 
    if (lb.SelectedIndex == -1) 
    { 
      // 選択されていない場合は何もしない。 
    } 
    else 
    { 
      lb.SetSelected(lb.SelectedIndex, false); 
      this.ActiveControl = null; 
    } 
  } 
 
  // リストボックスへ取得したファイル名を追記する。 
  private void WriteListBox(object sender, EventArgs e) 
  { 
    lb.Items.Clear(); 
    String TargetFolderPath = ".\\日付フォルダ\\" + dtp.Value.ToShortDateString().Replace("/","") + "\\"; 
    String[] FileNames = this.GetFileNameArray(TargetFolderPath); 
 
    foreach(String FileName in FileNames) 
    { 
      lb.Items.Add(FileName.Replace(TargetFolderPath, "")); 
    } 
  } 
 
  // フォルダ内のファイル名を取得する。 
  private String[] GetFileNameArray(String FolderPath) 
  { 
    if (Directory.Exists(FolderPath) == true) 
    { 
      return Directory.GetFiles(FolderPath, "*", SearchOption.TopDirectoryOnly); 
    } 
    else 
    { 
      return new String[] {"フォルダがないよ"}; 
    } 
  } 
} 