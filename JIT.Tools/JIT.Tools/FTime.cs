using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIT.Tools
{
  public partial class FTime : Form
  {
    public FTime()
    {
      InitializeComponent();
    }
    /// <summary>
    /// 窗体加载
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FTime_Load(object sender, EventArgs e)
    {
      CreateShortcut();
      txttime.Text = DateTime.Now.ToString();
      txttime.Enabled = false;
      txtStart.Text = "0";
      txtEnd.Text = "1";
    }

    /// <summary>
    /// 格式化时间
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnFormat_Click(object sender, EventArgs e)
    {
      string time = string.IsNullOrEmpty(txttime.Text.Trim()) ? DateTime.Now.ToString() : txttime.Text.Trim();
      DateTime dateTime = DateTime.Now;
      txttime.Text = dateTime.ToString();
      labShortDate.Text = "ToShortDateString:";
      txtShortDate.Text = dateTime.ToShortDateString();
      labShortTime.Text = "ToShortTimeString:";
      txtShortTime.Text = dateTime.ToShortTimeString();
      labLongDate.Text = "ToLongDateString:";
      txtLongDate.Text = dateTime.ToLongDateString();
      labLongTime.Text = "ToLongTimeString:";
      txtLongTime.Text = dateTime.ToLongTimeString();
      labToString.Text = "ToString:";
      txtToString.Text = dateTime.ToString();
    }

    /// <summary>
    /// GUID
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnGUID_Click(object sender, EventArgs e)
    {
      string GUID = Guid.NewGuid().ToString("N");
      textBox6.Text = "GUID:" + GUID + "  Len:" + GUID.Length;
      string GUIDNew = GUID.Substring(int.Parse(txtStart.Text.Trim()), int.Parse(txtEnd.Text.Trim())).ToUpper();
      string GUIDNew1 = "X" + DateTime.Now.Year + DateTime.Now.ToString("MM") + GUID.Substring(int.Parse(txtStart.Text.Trim()), int.Parse(txtEnd.Text.Trim())).ToUpper();
      textBox7.Text = "GUID:" + GUIDNew + "  Len:" + GUIDNew.Length;
      textBox8.Text = "GUID:" + GUIDNew1 + "  Len:" + GUIDNew1.Length;
    }

    /// <summary>
    /// 获取当前时间
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnGetDateTime_Click(object sender, EventArgs e)
    {
      txtTimestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }

    /// <summary>
    /// 获取时间戳
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnGetTimestamp_Click(object sender, EventArgs e)
    {
      TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
      string a = Convert.ToInt64(ts.TotalSeconds).ToString();
      TimeSpan cha = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1);
      cha.TotalMilliseconds.ToString();
      txtTimestamp.Text = a + " s / " + Convert.ToInt64(ts.TotalMilliseconds).ToString() + " ms";
    }

    /// <summary>
    /// 转大写
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnToUpper_Click(object sender, EventArgs e)
    {
      txtO.Text = txtT.Text.ToUpper();
    }

    /// <summary>
    /// 转小写
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnToLower_Click(object sender, EventArgs e)
    {
      txtO.Text = txtT.Text.ToLower();
    }


    private void CreateShortcut()
    {
      //添加引用 (com->Windows Script Host Object Model)，using IWshRuntimeLibrary;
      String shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Tools.lnk");
      if (!System.IO.File.Exists(shortcutPath))
      {
        // 获取当前应用程序目录地址
        String exePath = Process.GetCurrentProcess().MainModule.FileName;
        IWshShell shell = new WshShell();
        // 确定是否已经创建的快捷键被改名了
        foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "*.lnk"))
        {
          WshShortcut tempShortcut = (WshShortcut)shell.CreateShortcut(item);
          if (tempShortcut.TargetPath == exePath)
          {
            return;
          }
        }
        WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(shortcutPath);
        shortcut.TargetPath = exePath;
        shortcut.Arguments = "";// 参数  
        shortcut.Description = "应用程序说明";
        shortcut.WorkingDirectory = Environment.CurrentDirectory;//程序所在文件夹，在快捷方式图标点击右键可以看到此属性  
        shortcut.IconLocation = exePath;//图标，该图标是应用程序的资源文件
        //shortcut.Hotkey = "CTRL+SHIFT+W";//热键，发现没作用，大概需要注册一下  
        shortcut.WindowStyle = 1;
        shortcut.Save();
      }
    }
  }
}
