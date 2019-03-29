using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIT.Tools
{
  public partial class FInfo : Form
  {
    public FInfo()
    {
      InitializeComponent();
    }

    /// <summary>
    /// 获取IP信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Btn_Info_Click(object sender, EventArgs e)
    {
      txt_Info.Text = $"Browser:{Net.Net.Browser};操作系统:{Net.Net.GetWindows};" +
        $"用户:{Net.Net.GetWindowsUser};Ip:{Net.Net.Ip}";
    }

    private void BtnRight_Click(object sender, EventArgs e)
    {
      string str = txtOld.Text;
      this.txtNew.Text = str.Substring(str.Length - 4, 4);
    }

    private void BtnLeft_Click(object sender, EventArgs e)
    {
      string str = txtOld.Text;
      this.txtNew.Text = str.Substring(4);
    }
  }
}
