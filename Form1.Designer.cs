namespace Drifloon_watermark
{
    partial class Drifloon
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Suppress ALT+F4 and other user-initiated close attempts.
                e.Cancel = true;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Handle minimized state, e.g., keep the form in a certain location
                // and prevent unexpected behavior.
            }
            base.OnSizeChanged(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drifloon));
            SuspendLayout();
            // 
            // Drifloon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.drif;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(173, 272);
            ControlBox = false;
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Drifloon";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Drifloon";
            TopMost = true;
            TransparencyKey = SystemColors.ActiveCaption;
            ResumeLayout(false);
        }

        #endregion
    }

}