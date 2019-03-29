namespace JIT.Tools
{
  partial class FInfo
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btn_Info = new System.Windows.Forms.Button();
      this.txt_Info = new System.Windows.Forms.TextBox();
      this.labO = new System.Windows.Forms.Label();
      this.btnRight = new System.Windows.Forms.Button();
      this.txtOld = new System.Windows.Forms.TextBox();
      this.labN = new System.Windows.Forms.Label();
      this.txtNew = new System.Windows.Forms.TextBox();
      this.btnLeft = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_Info
      // 
      this.btn_Info.Location = new System.Drawing.Point(477, 23);
      this.btn_Info.Name = "btn_Info";
      this.btn_Info.Size = new System.Drawing.Size(92, 23);
      this.btn_Info.TabIndex = 0;
      this.btn_Info.Text = "获取IP信息";
      this.btn_Info.UseVisualStyleBackColor = true;
      this.btn_Info.Click += new System.EventHandler(this.Btn_Info_Click);
      // 
      // txt_Info
      // 
      this.txt_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txt_Info.Location = new System.Drawing.Point(13, 13);
      this.txt_Info.Multiline = true;
      this.txt_Info.Name = "txt_Info";
      this.txt_Info.Size = new System.Drawing.Size(458, 40);
      this.txt_Info.TabIndex = 1;
      // 
      // labO
      // 
      this.labO.AutoSize = true;
      this.labO.Location = new System.Drawing.Point(11, 103);
      this.labO.Name = "labO";
      this.labO.Size = new System.Drawing.Size(53, 12);
      this.labO.TabIndex = 2;
      this.labO.Text = "源数据：";
      // 
      // btnRight
      // 
      this.btnRight.Location = new System.Drawing.Point(477, 69);
      this.btnRight.Name = "btnRight";
      this.btnRight.Size = new System.Drawing.Size(75, 23);
      this.btnRight.TabIndex = 3;
      this.btnRight.Text = "截取右边";
      this.btnRight.UseVisualStyleBackColor = true;
      this.btnRight.Click += new System.EventHandler(this.BtnRight_Click);
      // 
      // txtOld
      // 
      this.txtOld.Location = new System.Drawing.Point(70, 100);
      this.txtOld.Multiline = true;
      this.txtOld.Name = "txtOld";
      this.txtOld.Size = new System.Drawing.Size(162, 54);
      this.txtOld.TabIndex = 4;
      // 
      // labN
      // 
      this.labN.AutoSize = true;
      this.labN.Location = new System.Drawing.Point(236, 103);
      this.labN.Name = "labN";
      this.labN.Size = new System.Drawing.Size(53, 12);
      this.labN.TabIndex = 2;
      this.labN.Text = "截取后：";
      // 
      // txtNew
      // 
      this.txtNew.Location = new System.Drawing.Point(295, 100);
      this.txtNew.Multiline = true;
      this.txtNew.Name = "txtNew";
      this.txtNew.Size = new System.Drawing.Size(162, 54);
      this.txtNew.TabIndex = 4;
      // 
      // btnLeft
      // 
      this.btnLeft.Location = new System.Drawing.Point(477, 100);
      this.btnLeft.Name = "btnLeft";
      this.btnLeft.Size = new System.Drawing.Size(75, 23);
      this.btnLeft.TabIndex = 3;
      this.btnLeft.Text = "截取左边";
      this.btnLeft.UseVisualStyleBackColor = true;
      this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
      // 
      // FInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(581, 253);
      this.Controls.Add(this.txtNew);
      this.Controls.Add(this.txtOld);
      this.Controls.Add(this.labN);
      this.Controls.Add(this.btnLeft);
      this.Controls.Add(this.btnRight);
      this.Controls.Add(this.labO);
      this.Controls.Add(this.txt_Info);
      this.Controls.Add(this.btn_Info);
      this.Name = "FInfo";
      this.Text = "FInfo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_Info;
    private System.Windows.Forms.TextBox txt_Info;
    private System.Windows.Forms.Label labO;
    private System.Windows.Forms.Button btnRight;
    private System.Windows.Forms.TextBox txtOld;
    private System.Windows.Forms.Label labN;
    private System.Windows.Forms.TextBox txtNew;
    private System.Windows.Forms.Button btnLeft;
  }
}