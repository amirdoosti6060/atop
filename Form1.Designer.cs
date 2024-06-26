namespace atop;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

        // Set the location
        this.StartPosition = FormStartPosition.Manual;
        this.DesktopLocation = new Point(Screen.PrimaryScreen.Bounds.X - 10, Screen.PrimaryScreen.Bounds.Y);

        // Set the size
        var screen = Screen.PrimaryScreen.WorkingArea.Size;
        this.ClientSize = new System.Drawing.Size(screen.Width, 222);

        // Set it always on top
        this.TopMost = true;
        this.Text = "Always on top form";
    }

    #endregion
}
