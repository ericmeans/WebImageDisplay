﻿namespace WebScreenSaver
{
  partial class ScreenSaverForm
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
      this.components = new System.ComponentModel.Container();
      this.backgroundChangeTimer = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // backgroundChangeTimer
      // 
      this.backgroundChangeTimer.Interval = 10000;
      this.backgroundChangeTimer.Tick += new System.EventHandler(this.backgroundChangeTimerTick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 212);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(343, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "This Form is drawn in the OnPaint() and OnPaintBackground() methods.";
      this.label1.Visible = false;
      // 
      // ScreenSaverForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(472, 459);
      this.ControlBox = false;
      this.Controls.Add(this.label1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ScreenSaverForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer backgroundChangeTimer;
    private System.Windows.Forms.Label label1;


  }
}