namespace Blackjack
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.NotificationText = new System.Windows.Forms.Label();
            this.closeBtnLog = new Bunifu.UI.WinForms.BunifuImageButton();
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Confirm.png");
            this.imageList1.Images.SetKeyName(1, "Error.png");
            this.imageList1.Images.SetKeyName(2, "Info.png");
            this.imageList1.Images.SetKeyName(3, "Warning.png");
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 22);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(90, 70);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // NotificationText
            // 
            this.NotificationText.AutoSize = true;
            this.NotificationText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationText.ForeColor = System.Drawing.Color.White;
            this.NotificationText.Location = new System.Drawing.Point(108, 48);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.Size = new System.Drawing.Size(74, 24);
            this.NotificationText.TabIndex = 1;
            this.NotificationText.Text = "label1";
            // 
            // closeBtnLog
            // 
            this.closeBtnLog.ActiveImage = null;
            this.closeBtnLog.AllowAnimations = true;
            this.closeBtnLog.AllowBuffering = false;
            this.closeBtnLog.AllowZooming = true;
            this.closeBtnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtnLog.BackColor = System.Drawing.Color.Transparent;
            this.closeBtnLog.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtnLog.ErrorImage")));
            this.closeBtnLog.FadeWhenInactive = false;
            this.closeBtnLog.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.closeBtnLog.Image = ((System.Drawing.Image)(resources.GetObject("closeBtnLog.Image")));
            this.closeBtnLog.ImageActive = null;
            this.closeBtnLog.ImageLocation = null;
            this.closeBtnLog.ImageMargin = 10;
            this.closeBtnLog.ImageSize = new System.Drawing.Size(15, 15);
            this.closeBtnLog.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.closeBtnLog.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeBtnLog.InitialImage")));
            this.closeBtnLog.Location = new System.Drawing.Point(427, 5);
            this.closeBtnLog.Name = "closeBtnLog";
            this.closeBtnLog.Rotation = 0;
            this.closeBtnLog.ShowActiveImage = true;
            this.closeBtnLog.ShowCursorChanges = true;
            this.closeBtnLog.ShowImageBorders = true;
            this.closeBtnLog.ShowSizeMarkers = false;
            this.closeBtnLog.Size = new System.Drawing.Size(25, 25);
            this.closeBtnLog.TabIndex = 14;
            this.closeBtnLog.ToolTipText = "";
            this.closeBtnLog.WaitOnLoad = false;
            this.closeBtnLog.Zoom = 10;
            this.closeBtnLog.ZoomSpeed = 10;
            this.closeBtnLog.Click += new System.EventHandler(this.CloseBtnLog_Click);
            // 
            // timeOut
            // 
            this.timeOut.Enabled = true;
            this.timeOut.Interval = 20000;
            this.timeOut.Tick += new System.EventHandler(this.TimeOut_Tick);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 1;
            this.timerShow.Tick += new System.EventHandler(this.TimerShow_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 25;
            this.timerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(457, 115);
            this.Controls.Add(this.closeBtnLog);
            this.Controls.Add(this.NotificationText);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label NotificationText;
        private Bunifu.UI.WinForms.BunifuImageButton closeBtnLog;
        private System.Windows.Forms.Timer timeOut;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}