namespace JIT.Tools
{
  partial class FTime
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
      this.button3 = new System.Windows.Forms.Button();
      this.labEnd = new System.Windows.Forms.Label();
      this.labStart = new System.Windows.Forms.Label();
      this.btnGUID = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtToString = new System.Windows.Forms.TextBox();
      this.txtLongTime = new System.Windows.Forms.TextBox();
      this.txtLongDate = new System.Windows.Forms.TextBox();
      this.txtShortTime = new System.Windows.Forms.TextBox();
      this.txtShortDate = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtEnd = new System.Windows.Forms.TextBox();
      this.txtStart = new System.Windows.Forms.TextBox();
      this.txttime = new System.Windows.Forms.TextBox();
      this.btnFormat = new System.Windows.Forms.Button();
      this.labShortDate = new System.Windows.Forms.Label();
      this.labShortTime = new System.Windows.Forms.Label();
      this.labLongDate = new System.Windows.Forms.Label();
      this.labLongTime = new System.Windows.Forms.Label();
      this.labToString = new System.Windows.Forms.Label();
      this.btnGetTimestamp = new System.Windows.Forms.Button();
      this.btnGetDateTime = new System.Windows.Forms.Button();
      this.txtTimestamp = new System.Windows.Forms.TextBox();
      this.txtO = new System.Windows.Forms.TextBox();
      this.btnToLower = new System.Windows.Forms.Button();
      this.btnToUpper = new System.Windows.Forms.Button();
      this.txtT = new System.Windows.Forms.TextBox();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(516, 14);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 17;
      this.button3.Text = "URL";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // labEnd
      // 
      this.labEnd.AutoSize = true;
      this.labEnd.Location = new System.Drawing.Point(179, 268);
      this.labEnd.Name = "labEnd";
      this.labEnd.Size = new System.Drawing.Size(35, 12);
      this.labEnd.TabIndex = 15;
      this.labEnd.Text = "End：";
      // 
      // labStart
      // 
      this.labStart.AutoSize = true;
      this.labStart.Location = new System.Drawing.Point(21, 268);
      this.labStart.Name = "labStart";
      this.labStart.Size = new System.Drawing.Size(47, 12);
      this.labStart.TabIndex = 16;
      this.labStart.Text = "Start：";
      // 
      // btnGUID
      // 
      this.btnGUID.Location = new System.Drawing.Point(371, 263);
      this.btnGUID.Name = "btnGUID";
      this.btnGUID.Size = new System.Drawing.Size(75, 23);
      this.btnGUID.TabIndex = 14;
      this.btnGUID.Text = "GUID";
      this.btnGUID.UseVisualStyleBackColor = true;
      this.btnGUID.Click += new System.EventHandler(this.BtnGUID_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox8);
      this.groupBox2.Controls.Add(this.textBox7);
      this.groupBox2.Controls.Add(this.textBox6);
      this.groupBox2.Location = new System.Drawing.Point(23, 292);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(450, 149);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "GUID显示：";
      // 
      // textBox8
      // 
      this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox8.Location = new System.Drawing.Point(22, 96);
      this.textBox8.Multiline = true;
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new System.Drawing.Size(380, 20);
      this.textBox8.TabIndex = 5;
      // 
      // textBox7
      // 
      this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox7.Location = new System.Drawing.Point(22, 59);
      this.textBox7.Multiline = true;
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new System.Drawing.Size(380, 20);
      this.textBox7.TabIndex = 5;
      // 
      // textBox6
      // 
      this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox6.Location = new System.Drawing.Point(22, 20);
      this.textBox6.Multiline = true;
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(380, 20);
      this.textBox6.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.labToString);
      this.groupBox1.Controls.Add(this.labLongTime);
      this.groupBox1.Controls.Add(this.labLongDate);
      this.groupBox1.Controls.Add(this.labShortTime);
      this.groupBox1.Controls.Add(this.labShortDate);
      this.groupBox1.Controls.Add(this.txtToString);
      this.groupBox1.Controls.Add(this.txtLongTime);
      this.groupBox1.Controls.Add(this.txtLongDate);
      this.groupBox1.Controls.Add(this.txtShortTime);
      this.groupBox1.Controls.Add(this.txtShortDate);
      this.groupBox1.Location = new System.Drawing.Point(23, 60);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(614, 191);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "格式化显示：";
      // 
      // txtToString
      // 
      this.txtToString.Location = new System.Drawing.Point(221, 146);
      this.txtToString.Name = "txtToString";
      this.txtToString.Size = new System.Drawing.Size(347, 21);
      this.txtToString.TabIndex = 1;
      // 
      // txtLongTime
      // 
      this.txtLongTime.Location = new System.Drawing.Point(221, 113);
      this.txtLongTime.Name = "txtLongTime";
      this.txtLongTime.Size = new System.Drawing.Size(347, 21);
      this.txtLongTime.TabIndex = 1;
      // 
      // txtLongDate
      // 
      this.txtLongDate.Location = new System.Drawing.Point(221, 76);
      this.txtLongDate.Name = "txtLongDate";
      this.txtLongDate.Size = new System.Drawing.Size(347, 21);
      this.txtLongDate.TabIndex = 1;
      // 
      // txtShortTime
      // 
      this.txtShortTime.Location = new System.Drawing.Point(221, 47);
      this.txtShortTime.Name = "txtShortTime";
      this.txtShortTime.Size = new System.Drawing.Size(347, 21);
      this.txtShortTime.TabIndex = 1;
      // 
      // txtShortDate
      // 
      this.txtShortDate.Location = new System.Drawing.Point(221, 20);
      this.txtShortDate.Name = "txtShortDate";
      this.txtShortDate.Size = new System.Drawing.Size(347, 21);
      this.txtShortDate.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 12);
      this.label1.TabIndex = 11;
      this.label1.Text = "TimeNow：";
      // 
      // txtEnd
      // 
      this.txtEnd.Location = new System.Drawing.Point(244, 265);
      this.txtEnd.Name = "txtEnd";
      this.txtEnd.Size = new System.Drawing.Size(70, 21);
      this.txtEnd.TabIndex = 8;
      // 
      // txtStart
      // 
      this.txtStart.Location = new System.Drawing.Point(86, 265);
      this.txtStart.Name = "txtStart";
      this.txtStart.Size = new System.Drawing.Size(70, 21);
      this.txtStart.TabIndex = 9;
      // 
      // txttime
      // 
      this.txttime.Location = new System.Drawing.Point(86, 14);
      this.txttime.Name = "txttime";
      this.txttime.Size = new System.Drawing.Size(237, 21);
      this.txttime.TabIndex = 10;
      // 
      // btnFormat
      // 
      this.btnFormat.Location = new System.Drawing.Point(411, 13);
      this.btnFormat.Name = "btnFormat";
      this.btnFormat.Size = new System.Drawing.Size(75, 23);
      this.btnFormat.TabIndex = 7;
      this.btnFormat.Text = "格式化";
      this.btnFormat.UseVisualStyleBackColor = true;
      this.btnFormat.Click += new System.EventHandler(this.BtnFormat_Click);
      // 
      // labShortDate
      // 
      this.labShortDate.AutoSize = true;
      this.labShortDate.Location = new System.Drawing.Point(63, 25);
      this.labShortDate.Name = "labShortDate";
      this.labShortDate.Size = new System.Drawing.Size(83, 12);
      this.labShortDate.TabIndex = 2;
      this.labShortDate.Text = "labShortDate:";
      // 
      // labShortTime
      // 
      this.labShortTime.AutoSize = true;
      this.labShortTime.Location = new System.Drawing.Point(61, 52);
      this.labShortTime.Name = "labShortTime";
      this.labShortTime.Size = new System.Drawing.Size(83, 12);
      this.labShortTime.TabIndex = 2;
      this.labShortTime.Text = "labShortTime:";
      // 
      // labLongDate
      // 
      this.labLongDate.AutoSize = true;
      this.labLongDate.Location = new System.Drawing.Point(61, 81);
      this.labLongDate.Name = "labLongDate";
      this.labLongDate.Size = new System.Drawing.Size(77, 12);
      this.labLongDate.TabIndex = 2;
      this.labLongDate.Text = "labLongDate:";
      // 
      // labLongTime
      // 
      this.labLongTime.AutoSize = true;
      this.labLongTime.Location = new System.Drawing.Point(61, 118);
      this.labLongTime.Name = "labLongTime";
      this.labLongTime.Size = new System.Drawing.Size(77, 12);
      this.labLongTime.TabIndex = 2;
      this.labLongTime.Text = "labLongTime:";
      // 
      // labToString
      // 
      this.labToString.AutoSize = true;
      this.labToString.Location = new System.Drawing.Point(61, 151);
      this.labToString.Name = "labToString";
      this.labToString.Size = new System.Drawing.Size(77, 12);
      this.labToString.TabIndex = 2;
      this.labToString.Text = "labToString:";
      // 
      // btnGetTimestamp
      // 
      this.btnGetTimestamp.Location = new System.Drawing.Point(929, 41);
      this.btnGetTimestamp.Name = "btnGetTimestamp";
      this.btnGetTimestamp.Size = new System.Drawing.Size(101, 23);
      this.btnGetTimestamp.TabIndex = 20;
      this.btnGetTimestamp.Text = "获取当前时间戳";
      this.btnGetTimestamp.UseVisualStyleBackColor = true;
      this.btnGetTimestamp.Click += new System.EventHandler(this.BtnGetTimestamp_Click);
      // 
      // btnGetDateTime
      // 
      this.btnGetDateTime.Location = new System.Drawing.Point(929, 12);
      this.btnGetDateTime.Name = "btnGetDateTime";
      this.btnGetDateTime.Size = new System.Drawing.Size(101, 23);
      this.btnGetDateTime.TabIndex = 19;
      this.btnGetDateTime.Text = "获取当前时间";
      this.btnGetDateTime.UseVisualStyleBackColor = true;
      this.btnGetDateTime.Click += new System.EventHandler(this.BtnGetDateTime_Click);
      // 
      // txtTimestamp
      // 
      this.txtTimestamp.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtTimestamp.Location = new System.Drawing.Point(653, 12);
      this.txtTimestamp.Multiline = true;
      this.txtTimestamp.Name = "txtTimestamp";
      this.txtTimestamp.Size = new System.Drawing.Size(238, 52);
      this.txtTimestamp.TabIndex = 18;
      // 
      // txtO
      // 
      this.txtO.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtO.Location = new System.Drawing.Point(653, 168);
      this.txtO.Multiline = true;
      this.txtO.Name = "txtO";
      this.txtO.Size = new System.Drawing.Size(238, 59);
      this.txtO.TabIndex = 24;
      // 
      // btnToLower
      // 
      this.btnToLower.Location = new System.Drawing.Point(915, 178);
      this.btnToLower.Name = "btnToLower";
      this.btnToLower.Size = new System.Drawing.Size(100, 23);
      this.btnToLower.TabIndex = 23;
      this.btnToLower.Text = "转小写";
      this.btnToLower.UseVisualStyleBackColor = true;
      this.btnToLower.Click += new System.EventHandler(this.BtnToLower_Click);
      // 
      // btnToUpper
      // 
      this.btnToUpper.Location = new System.Drawing.Point(915, 112);
      this.btnToUpper.Name = "btnToUpper";
      this.btnToUpper.Size = new System.Drawing.Size(100, 23);
      this.btnToUpper.TabIndex = 22;
      this.btnToUpper.Text = "转大写";
      this.btnToUpper.UseVisualStyleBackColor = true;
      this.btnToUpper.Click += new System.EventHandler(this.BtnToUpper_Click);
      // 
      // txtT
      // 
      this.txtT.Location = new System.Drawing.Point(653, 80);
      this.txtT.Multiline = true;
      this.txtT.Name = "txtT";
      this.txtT.Size = new System.Drawing.Size(238, 70);
      this.txtT.TabIndex = 21;
      // 
      // FTime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1140, 474);
      this.Controls.Add(this.txtO);
      this.Controls.Add(this.btnToLower);
      this.Controls.Add(this.btnToUpper);
      this.Controls.Add(this.txtT);
      this.Controls.Add(this.btnGetTimestamp);
      this.Controls.Add(this.btnGetDateTime);
      this.Controls.Add(this.txtTimestamp);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.labEnd);
      this.Controls.Add(this.labStart);
      this.Controls.Add(this.btnGUID);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtEnd);
      this.Controls.Add(this.txtStart);
      this.Controls.Add(this.txttime);
      this.Controls.Add(this.btnFormat);
      this.Name = "FTime";
      this.Text = "FTime";
      this.Load += new System.EventHandler(this.FTime_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label labEnd;
    private System.Windows.Forms.Label labStart;
    private System.Windows.Forms.Button btnGUID;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtToString;
    private System.Windows.Forms.TextBox txtLongTime;
    private System.Windows.Forms.TextBox txtLongDate;
    private System.Windows.Forms.TextBox txtShortTime;
    private System.Windows.Forms.TextBox txtShortDate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtEnd;
    private System.Windows.Forms.TextBox txtStart;
    private System.Windows.Forms.TextBox txttime;
    private System.Windows.Forms.Button btnFormat;
    private System.Windows.Forms.Label labShortDate;
    private System.Windows.Forms.Label labShortTime;
    private System.Windows.Forms.Label labLongDate;
    private System.Windows.Forms.Label labLongTime;
    private System.Windows.Forms.Label labToString;
    private System.Windows.Forms.Button btnGetTimestamp;
    private System.Windows.Forms.Button btnGetDateTime;
    private System.Windows.Forms.TextBox txtTimestamp;
    private System.Windows.Forms.TextBox txtO;
    private System.Windows.Forms.Button btnToLower;
    private System.Windows.Forms.Button btnToUpper;
    private System.Windows.Forms.TextBox txtT;
  }
}