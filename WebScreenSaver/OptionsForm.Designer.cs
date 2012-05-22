namespace WebScreenSaver
{
  partial class OptionsForm : System.Windows.Forms.Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.applyButton = new System.Windows.Forms.Button();
      this.rssGroupBox = new System.Windows.Forms.GroupBox();
      this.imageUrlsTextBox = new System.Windows.Forms.TextBox();
      this.imageGroupBox = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.intervalTextBox = new System.Windows.Forms.TextBox();
      this.radioImageModeCenter = new System.Windows.Forms.RadioButton();
      this.radioImageModeStretch = new System.Windows.Forms.RadioButton();
      this.backgroundImageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.backgroundImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.MonitorSelectListbox = new System.Windows.Forms.ComboBox();
      this.rssGroupBox.SuspendLayout();
      this.imageGroupBox.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // okButton
      // 
      this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.okButton.Location = new System.Drawing.Point(156, 3);
      this.okButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 1;
      this.okButton.Text = "OK";
      this.okButton.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(74, 3);
      this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 2;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // applyButton
      // 
      this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.applyButton.Location = new System.Drawing.Point(237, 3);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 3;
      this.applyButton.Text = "Apply";
      this.applyButton.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // rssGroupBox
      // 
      this.rssGroupBox.Controls.Add(this.imageUrlsTextBox);
      this.rssGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rssGroupBox.Location = new System.Drawing.Point(3, 3);
      this.rssGroupBox.Name = "rssGroupBox";
      this.rssGroupBox.Size = new System.Drawing.Size(315, 119);
      this.rssGroupBox.TabIndex = 4;
      this.rssGroupBox.TabStop = false;
      this.rssGroupBox.Text = "Image URLs:";
      // 
      // imageUrlsTextBox
      // 
      this.imageUrlsTextBox.AcceptsReturn = true;
      this.imageUrlsTextBox.Location = new System.Drawing.Point(7, 19);
      this.imageUrlsTextBox.Multiline = true;
      this.imageUrlsTextBox.Name = "imageUrlsTextBox";
      this.imageUrlsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.imageUrlsTextBox.Size = new System.Drawing.Size(301, 91);
      this.imageUrlsTextBox.TabIndex = 0;
      this.imageUrlsTextBox.WordWrap = false;
      this.imageUrlsTextBox.TextChanged += new System.EventHandler(this.imageUrlsTextBox_TextChanged);
      // 
      // imageGroupBox
      // 
      this.imageGroupBox.Controls.Add(this.MonitorSelectListbox);
      this.imageGroupBox.Controls.Add(this.label2);
      this.imageGroupBox.Controls.Add(this.label1);
      this.imageGroupBox.Controls.Add(this.intervalTextBox);
      this.imageGroupBox.Controls.Add(this.radioImageModeCenter);
      this.imageGroupBox.Controls.Add(this.radioImageModeStretch);
      this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imageGroupBox.Location = new System.Drawing.Point(3, 128);
      this.imageGroupBox.Name = "imageGroupBox";
      this.imageGroupBox.Size = new System.Drawing.Size(315, 73);
      this.imageGroupBox.TabIndex = 5;
      this.imageGroupBox.TabStop = false;
      this.imageGroupBox.Text = "Image Settings";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(202, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Interval (s)";
      // 
      // intervalTextBox
      // 
      this.intervalTextBox.Location = new System.Drawing.Point(264, 18);
      this.intervalTextBox.MaxLength = 5;
      this.intervalTextBox.Name = "intervalTextBox";
      this.intervalTextBox.Size = new System.Drawing.Size(44, 20);
      this.intervalTextBox.TabIndex = 2;
      this.intervalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.intervalTextBox_KeyDown);
      // 
      // radioImageModeCenter
      // 
      this.radioImageModeCenter.AutoSize = true;
      this.radioImageModeCenter.Location = new System.Drawing.Point(74, 19);
      this.radioImageModeCenter.Name = "radioImageModeCenter";
      this.radioImageModeCenter.Size = new System.Drawing.Size(56, 17);
      this.radioImageModeCenter.TabIndex = 1;
      this.radioImageModeCenter.Text = "Center";
      this.radioImageModeCenter.UseVisualStyleBackColor = true;
      this.radioImageModeCenter.CheckedChanged += new System.EventHandler(this.radioImageModeCenter_CheckedChanged);
      // 
      // radioImageModeStretch
      // 
      this.radioImageModeStretch.AutoSize = true;
      this.radioImageModeStretch.Checked = true;
      this.radioImageModeStretch.Location = new System.Drawing.Point(7, 19);
      this.radioImageModeStretch.Name = "radioImageModeStretch";
      this.radioImageModeStretch.Size = new System.Drawing.Size(59, 17);
      this.radioImageModeStretch.TabIndex = 0;
      this.radioImageModeStretch.TabStop = true;
      this.radioImageModeStretch.Text = "Stretch";
      this.radioImageModeStretch.UseVisualStyleBackColor = true;
      this.radioImageModeStretch.CheckedChanged += new System.EventHandler(this.radioImageModeStretch_CheckedChanged);
      // 
      // backgroundImageFolderBrowser
      // 
      this.backgroundImageFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyPictures;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.imageGroupBox, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.rssGroupBox, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.27451F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.72549F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 240);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
      this.tableLayoutPanel2.Controls.Add(this.applyButton, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.cancelButton, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.okButton, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 207);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 30);
      this.tableLayoutPanel2.TabIndex = 6;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Monitor:";
      // 
      // MonitorSelectListbox
      // 
      this.MonitorSelectListbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.MonitorSelectListbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.MonitorSelectListbox.FormattingEnabled = true;
      this.MonitorSelectListbox.Location = new System.Drawing.Point(57, 45);
      this.MonitorSelectListbox.Name = "MonitorSelectListbox";
      this.MonitorSelectListbox.Size = new System.Drawing.Size(251, 21);
      this.MonitorSelectListbox.TabIndex = 5;
      // 
      // OptionsForm
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(339, 258);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "OptionsForm";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.Text = "Screen Saver Settings";
      this.rssGroupBox.ResumeLayout(false);
      this.rssGroupBox.PerformLayout();
      this.imageGroupBox.ResumeLayout(false);
      this.imageGroupBox.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button applyButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.OpenFileDialog backgroundImageOpenFileDialog;
    private System.Windows.Forms.GroupBox rssGroupBox;
    private System.Windows.Forms.TextBox imageUrlsTextBox;
    private System.Windows.Forms.GroupBox imageGroupBox;
    private System.Windows.Forms.FolderBrowserDialog backgroundImageFolderBrowser;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.RadioButton radioImageModeCenter;
    private System.Windows.Forms.RadioButton radioImageModeStretch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox intervalTextBox;
    private System.Windows.Forms.ComboBox MonitorSelectListbox;
    private System.Windows.Forms.Label label2;
  }
}