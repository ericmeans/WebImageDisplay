using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace WebScreenSaver
{
  public enum ImageMode
  {
    Stretch,
    Center
  }

  partial class ScreenSaverForm : Form
  {
    // The images to display in the background
    private int currentImageIndex;

    // Keep track of whether the screensaver has become active.
    private bool isActive = false;

    // Keep track of the location of the mouse
    private Point mouseLocation;

    private Image currentImage;
    private string exceptionInfo = string.Empty;

    public ScreenSaverForm()
    {
      // Move to the selected screen, if necessary.
      string deviceName = Properties.Settings.Default.DisplayMonitor;
      if (Screen.AllScreens.Length > 1 && Properties.Settings.Default.DisplayMonitor != null &&
        Properties.Settings.Default.DisplayMonitor.Length > 0)
      {
        foreach (Screen screen in Screen.AllScreens)
        {
          string screenName = screen.DeviceName;
          // Seems like the API doesn't properly respect null-termination.
          if (screenName.Contains("\0"))
            screenName = screenName.Remove(screenName.IndexOf('\0'));
          if (deviceName.Equals(screenName))
          {
            // Move the form to this screen
            this.Bounds = screen.Bounds;
          }
        }
      }
      else
      {
        this.Bounds = Screen.PrimaryScreen.Bounds;
      }

      InitializeComponent();

      SetupScreenSaver();
    }

    /// <summary>
    /// Set up the main form as a full screen screensaver.
    /// </summary>
    private void SetupScreenSaver()
    {
      // Use double buffering to improve drawing performance
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
      // Capture the mouse
      this.Capture = true;

      if (Properties.Settings.Default.ImageUrlList == null)
        Properties.Settings.Default.ImageUrlList = new System.Collections.Specialized.StringCollection();

      // Set the application to full screen mode and hide the mouse
      Cursor.Hide();
      if (Properties.Settings.Default.ImageMode == ImageMode.Stretch)
        BackgroundImageLayout = ImageLayout.Stretch;
      else
        BackgroundImageLayout = ImageLayout.Center;
      backgroundChangeTimer.Interval = Properties.Settings.Default.ImageChangeTime * 1000;
      GetCurrentImage();
      backgroundChangeTimer.Enabled = true;
    }

    private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
    {
      // Set IsActive and MouseLocation only the first time this event is called.
      if (!isActive)
      {
        mouseLocation = MousePosition;
        isActive = true;
      }
      else
      {
        // If the mouse has moved significantly since first call, close.
        if ((Math.Abs(MousePosition.X - mouseLocation.X) > 10) ||
            (Math.Abs(MousePosition.Y - mouseLocation.Y) > 10))
        {
          Close();
        }
      }
    }

    private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
    {
      Close();

    }

    private void ScreenSaverForm_MouseDown(object sender, MouseEventArgs e)
    {
      Close();
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
      e.Graphics.DrawRectangle(Pens.Black, 0, 0, Size.Width, Size.Height);
      if (currentImage != null)
      {
        if (Properties.Settings.Default.ImageMode == ImageMode.Center)
        {
          e.Graphics.DrawImage(currentImage, (Size.Width - currentImage.Width) / 2, (Size.Height - currentImage.Height) / 2,
            currentImage.Width, currentImage.Height);
        }
        else
        {
          int height;
          int width;
          GetImageStretchSize(out height, out width);
          e.Graphics.DrawImage(currentImage, (Size.Width - width) / 2, (Size.Height - height) / 2, width, height);
        }
      }
    }

    private void GetImageStretchSize(out int height, out int width)
    {
      float aspectRatio = (float)currentImage.Width / currentImage.Height;
      int deltaW;
      int deltaH;
      if (currentImage.Width <= Size.Width && currentImage.Height <= Size.Height)
      {
        // Scale the image up, maintaining aspect ratio.
        // Figure out whether the height or width is more problematic.
        deltaW = Size.Width - currentImage.Width;
        deltaH = Size.Height - currentImage.Height;
        if (deltaW < deltaH)
        {
          // Width is the larger issue. Shrink the width, then recalculate height to match.
          width = Size.Width;
          height = (int)(width / aspectRatio);
        }
        else
        {
          // Height is the larger issue. Shrink the height, then recalculate width to match.
          height = Size.Height;
          width = (int)(aspectRatio * height);
        }
      }
      else
      {
        // Scale the image down, maintaining aspect ratio.
        // Figure out whether the height or width is more problematic.
        deltaW = currentImage.Width - Size.Width;
        deltaH = currentImage.Height - Size.Height;
        if (deltaW > deltaH)
        {
          // Width is the larger issue. Shrink the width, then recalculate height to match.
          width = Size.Width;
          height = (int)(width / aspectRatio);
        }
        else
        {
          // Height is the larger issue. Shrink the height, then recalculate width to match.
          height = Size.Height;
          width = (int)(aspectRatio * height);
        }
      }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if (exceptionInfo.Length > 0)
      {
        e.Graphics.DrawString(exceptionInfo, Font, Brushes.Orange, new PointF(Size.Width / 10, Size.Height / 10));
      }
    }

    private void backgroundChangeTimerTick(object sender, EventArgs e)
    {
      backgroundChangeTimer.Enabled = false;
      // Change the background image to the next image.
      currentImageIndex = (currentImageIndex + 1) % Properties.Settings.Default.ImageUrlList.Count;
      GetCurrentImage();
      Refresh();
      backgroundChangeTimer.Enabled = true;
    }

    private void GetCurrentImage()
    {
      exceptionInfo = string.Empty;
      currentImage = null;

      if (Properties.Settings.Default.ImageUrlList.Count == 0)
      {
        exceptionInfo = "No URLs have been supplied; nothing to display.";
        return;
      }

      WebClient client = new WebClient();
      try
      {
        Uri url = new Uri(Properties.Settings.Default.ImageUrlList[currentImageIndex]);
        byte[] imageBytes = client.DownloadData(url);
        using (MemoryStream stream = new MemoryStream(imageBytes))
          currentImage = Image.FromStream(stream);
      }
      catch (ArgumentException)
      {
        exceptionInfo = "Unable to download the requested image. Check that the URL is correct and not password-protected.";
      }
      catch (Exception ex)
      {
        exceptionInfo = ex.ToString();
      }
    }
  }
}
