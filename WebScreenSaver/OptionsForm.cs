using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;


namespace WebScreenSaver
{
  partial class OptionsForm : Form
  {
    public OptionsForm()
    {
      InitializeComponent();

      // Load the text boxes from the current settings
      try
      {
        if (Properties.Settings.Default.ImageUrlList == null)
          Properties.Settings.Default.ImageUrlList = new System.Collections.Specialized.StringCollection();
        foreach (string url in Properties.Settings.Default.ImageUrlList)
          imageUrlsTextBox.AppendText(url + Environment.NewLine);
        if (Properties.Settings.Default.ImageMode == ImageMode.Stretch)
          radioImageModeStretch.Checked = true;
        else
          radioImageModeCenter.Checked = true;
        intervalTextBox.Text = Properties.Settings.Default.ImageChangeTime.ToString();
        // Load the monitor list
        if (Screen.AllScreens.Length == 1)
        {
          MonitorSelectListbox.Text = "Primary Monitor";
          MonitorSelectListbox.Enabled = false;
        }
        else
        {
          int i = 0;
          int selectedIndex = 0;
          string displayMonitor = Properties.Settings.Default.DisplayMonitor;
          foreach (Screen screen in Screen.AllScreens)
          {
            // Seems like the API doesn't properly respect null-termination.
            string deviceName = screen.DeviceName;
            if (deviceName.Contains("\0"))
              deviceName = deviceName.Remove(deviceName.IndexOf('\0'));
            MonitorSelectListbox.Items.Add(string.Format("Monitor {0} [{1}x{2}] ({3}{4})", ++i,
              screen.Bounds.Width, screen.Bounds.Height, (screen.Primary ? "Primary: " : ""), deviceName));
            if ((displayMonitor != null && displayMonitor.Length > 0 && displayMonitor.Equals(deviceName)) ||
              ((displayMonitor == null || displayMonitor.Length == 0) && screen.Primary))
            {
              selectedIndex = i - 1;
            }
          }
          MonitorSelectListbox.SelectedIndex = selectedIndex;
        }
      }
      catch
      {
        MessageBox.Show("There was a problem reading in the settings for your screen saver.");
      }
    }

    // Update the apply button to be active only if changes 
    // have been made since apply was last pressed
    private void UpdateApply()
    {
      applyButton.Enabled = true;
    }

    // Apply all the changes since apply button was last pressed
    private void ApplyChanges()
    {
      Properties.Settings.Default.ImageUrlList.Clear();
      imageUrlsTextBox.Text = imageUrlsTextBox.Text.Trim();
      Properties.Settings.Default.ImageUrlList.AddRange(imageUrlsTextBox.Lines);
      if (radioImageModeStretch.Checked)
        Properties.Settings.Default.ImageMode = ImageMode.Stretch;
      else
        Properties.Settings.Default.ImageMode = ImageMode.Center;
      Properties.Settings.Default.ImageChangeTime = int.Parse(intervalTextBox.Text);
      string deviceName = Screen.AllScreens[MonitorSelectListbox.SelectedIndex].DeviceName;
      // Seems like the API doesn't properly respect null-termination.
      if (deviceName.Contains("\0"))
        deviceName = deviceName.Remove(deviceName.IndexOf('\0'));
      Properties.Settings.Default.DisplayMonitor = deviceName;
      Properties.Settings.Default.Save();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      try
      {
        ApplyChanges();
      }
      catch (ConfigurationException)
      {
        MessageBox.Show("Your settings couldn't be saved.  Make sure that you have a .config file in the same directory as your screensaver.", "Failed to Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        Close();
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      ApplyChanges();
      applyButton.Enabled = false;
    }

    private void imageUrlsTextBox_TextChanged(object sender, EventArgs e)
    {
      UpdateApply();
    }

    private void radioImageModeStretch_CheckedChanged(object sender, EventArgs e)
    {
      UpdateApply();
    }

    private void radioImageModeCenter_CheckedChanged(object sender, EventArgs e)
    {
      UpdateApply();
    }

    private void intervalTextBox_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.D0:
        case Keys.D1:
        case Keys.D2:
        case Keys.D3:
        case Keys.D4:
        case Keys.D5:
        case Keys.D6:
        case Keys.D7:
        case Keys.D8:
        case Keys.D9:
        case Keys.NumPad0:
        case Keys.NumPad1:
        case Keys.NumPad2:
        case Keys.NumPad3:
        case Keys.NumPad4:
        case Keys.NumPad5:
        case Keys.NumPad6:
        case Keys.NumPad7:
        case Keys.NumPad8:
        case Keys.NumPad9:
        case Keys.Tab:
        case Keys.Enter:
        case Keys.Back:
        case Keys.Delete:
          return;
        default:
          e.Handled = true;
          e.SuppressKeyPress = true;
          return;
      }
    }
  }
}