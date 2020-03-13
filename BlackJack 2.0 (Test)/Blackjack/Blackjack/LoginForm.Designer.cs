namespace Blackjack
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.createAccLabel = new System.Windows.Forms.Label();
            this.closeBtnLog = new Bunifu.UI.WinForms.BunifuImageButton();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logPasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.logPlayerNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.alredyHaveLabel = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.regiserButton = new System.Windows.Forms.Button();
            this.emailTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.rePasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RePasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.playerNmTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.signUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(402, 712);
            this.panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(98, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Play, Win\r\nEarn Money\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.registerPanel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(402, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(398, 712);
            this.panelRight.TabIndex = 1;
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.signUpPanel);
            this.registerPanel.Controls.Add(this.alredyHaveLabel);
            this.registerPanel.Controls.Add(this.closeButton);
            this.registerPanel.Controls.Add(this.regiserButton);
            this.registerPanel.Controls.Add(this.emailTextbox);
            this.registerPanel.Controls.Add(this.EmailLabel);
            this.registerPanel.Controls.Add(this.rePasswordTextBox);
            this.registerPanel.Controls.Add(this.RePasswordLabel);
            this.registerPanel.Controls.Add(this.passwordTextBox);
            this.registerPanel.Controls.Add(this.PasswordLabel);
            this.registerPanel.Controls.Add(this.playerNmTextBox);
            this.registerPanel.Controls.Add(this.UserNameLabel);
            this.registerPanel.Controls.Add(this.RegisterLabel);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(398, 712);
            this.registerPanel.TabIndex = 2;
            // 
            // signUpPanel
            // 
            this.signUpPanel.Controls.Add(this.createAccLabel);
            this.signUpPanel.Controls.Add(this.closeBtnLog);
            this.signUpPanel.Controls.Add(this.signUpButton);
            this.signUpPanel.Controls.Add(this.logPasswordTextBox);
            this.signUpPanel.Controls.Add(this.label5);
            this.signUpPanel.Controls.Add(this.logPlayerNameTextBox);
            this.signUpPanel.Controls.Add(this.label6);
            this.signUpPanel.Controls.Add(this.SignUpLabel);
            this.signUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpPanel.Location = new System.Drawing.Point(0, 0);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(398, 712);
            this.signUpPanel.TabIndex = 15;
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.createAccLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.createAccLabel.Location = new System.Drawing.Point(188, 498);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new System.Drawing.Size(191, 21);
            this.createAccLabel.TabIndex = 14;
            this.createAccLabel.Text = "Create a new account";
            this.createAccLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createAccLabel.Click += new System.EventHandler(this.CreateAccLabel_Click);
            this.createAccLabel.MouseEnter += new System.EventHandler(this.CreateAccLabel_MouseEnter);
            this.createAccLabel.MouseLeave += new System.EventHandler(this.CreateAccLabel_MouseLeave);
            // 
            // closeBtnLog
            // 
            this.closeBtnLog.ActiveImage = null;
            this.closeBtnLog.AllowAnimations = true;
            this.closeBtnLog.AllowBuffering = false;
            this.closeBtnLog.AllowZooming = true;
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
            this.closeBtnLog.Location = new System.Drawing.Point(369, 4);
            this.closeBtnLog.Name = "closeBtnLog";
            this.closeBtnLog.Rotation = 0;
            this.closeBtnLog.ShowActiveImage = true;
            this.closeBtnLog.ShowCursorChanges = true;
            this.closeBtnLog.ShowImageBorders = true;
            this.closeBtnLog.ShowSizeMarkers = false;
            this.closeBtnLog.Size = new System.Drawing.Size(25, 25);
            this.closeBtnLog.TabIndex = 13;
            this.closeBtnLog.ToolTipText = "";
            this.closeBtnLog.WaitOnLoad = false;
            this.closeBtnLog.Zoom = 10;
            this.closeBtnLog.ZoomSpeed = 10;
            this.closeBtnLog.Click += new System.EventHandler(this.CloseBtnLog_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.signUpButton.Location = new System.Drawing.Point(17, 441);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(362, 48);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // logPasswordTextBox
            // 
            this.logPasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.logPasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.logPasswordTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.logPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logPasswordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.logPasswordTextBox.HintText = "Your Password";
            this.logPasswordTextBox.isPassword = true;
            this.logPasswordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPasswordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPasswordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPasswordTextBox.LineThickness = 3;
            this.logPasswordTextBox.Location = new System.Drawing.Point(17, 317);
            this.logPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logPasswordTextBox.MaxLength = 32767;
            this.logPasswordTextBox.Name = "logPasswordTextBox";
            this.logPasswordTextBox.Size = new System.Drawing.Size(362, 33);
            this.logPasswordTextBox.TabIndex = 7;
            this.logPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(13, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logPlayerNameTextBox
            // 
            this.logPlayerNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.logPlayerNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.logPlayerNameTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logPlayerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logPlayerNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.logPlayerNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logPlayerNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.logPlayerNameTextBox.HintText = "Player Nickname";
            this.logPlayerNameTextBox.isPassword = false;
            this.logPlayerNameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPlayerNameTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPlayerNameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.logPlayerNameTextBox.LineThickness = 3;
            this.logPlayerNameTextBox.Location = new System.Drawing.Point(17, 241);
            this.logPlayerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.logPlayerNameTextBox.MaxLength = 32767;
            this.logPlayerNameTextBox.Name = "logPlayerNameTextBox";
            this.logPlayerNameTextBox.Size = new System.Drawing.Size(362, 33);
            this.logPlayerNameTextBox.TabIndex = 5;
            this.logPlayerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "User Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.SignUpLabel.Location = new System.Drawing.Point(12, 173);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(101, 30);
            this.SignUpLabel.TabIndex = 3;
            this.SignUpLabel.Text = "Sign Up";
            this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alredyHaveLabel
            // 
            this.alredyHaveLabel.AutoSize = true;
            this.alredyHaveLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.alredyHaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.alredyHaveLabel.Location = new System.Drawing.Point(170, 571);
            this.alredyHaveLabel.Name = "alredyHaveLabel";
            this.alredyHaveLabel.Size = new System.Drawing.Size(209, 21);
            this.alredyHaveLabel.TabIndex = 14;
            this.alredyHaveLabel.Text = "I alredy have an account";
            this.alredyHaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alredyHaveLabel.Click += new System.EventHandler(this.AlredyHaveLabel_Click);
            this.alredyHaveLabel.MouseEnter += new System.EventHandler(this.CrNewAccLabel_MouseEnter);
            this.alredyHaveLabel.MouseLeave += new System.EventHandler(this.CrNewAccLabel_MouseLeave);
            // 
            // closeButton
            // 
            this.closeButton.ActiveImage = null;
            this.closeButton.AllowAnimations = true;
            this.closeButton.AllowBuffering = false;
            this.closeButton.AllowZooming = true;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeButton.ErrorImage")));
            this.closeButton.FadeWhenInactive = false;
            this.closeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.ImageLocation = null;
            this.closeButton.ImageMargin = 10;
            this.closeButton.ImageSize = new System.Drawing.Size(15, 15);
            this.closeButton.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(369, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Rotation = 0;
            this.closeButton.ShowActiveImage = true;
            this.closeButton.ShowCursorChanges = true;
            this.closeButton.ShowImageBorders = true;
            this.closeButton.ShowSizeMarkers = false;
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 13;
            this.closeButton.ToolTipText = "";
            this.closeButton.WaitOnLoad = false;
            this.closeButton.Zoom = 10;
            this.closeButton.ZoomSpeed = 10;
            this.closeButton.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // regiserButton
            // 
            this.regiserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.regiserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regiserButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regiserButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regiserButton.Location = new System.Drawing.Point(17, 514);
            this.regiserButton.Name = "regiserButton";
            this.regiserButton.Size = new System.Drawing.Size(362, 48);
            this.regiserButton.TabIndex = 12;
            this.regiserButton.Text = "Register";
            this.regiserButton.UseVisualStyleBackColor = false;
            this.regiserButton.Click += new System.EventHandler(this.RegiserButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.emailTextbox.HintText = "yournickname@example.ru";
            this.emailTextbox.isPassword = false;
            this.emailTextbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.emailTextbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.emailTextbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.emailTextbox.LineThickness = 3;
            this.emailTextbox.Location = new System.Drawing.Point(17, 401);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextbox.MaxLength = 32767;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(362, 33);
            this.emailTextbox.TabIndex = 11;
            this.emailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.EmailLabel.Location = new System.Drawing.Point(13, 376);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(55, 21);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rePasswordTextBox
            // 
            this.rePasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rePasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rePasswordTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.rePasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rePasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rePasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rePasswordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.rePasswordTextBox.HintText = "Your Password";
            this.rePasswordTextBox.isPassword = true;
            this.rePasswordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.rePasswordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.rePasswordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.rePasswordTextBox.LineThickness = 3;
            this.rePasswordTextBox.Location = new System.Drawing.Point(17, 321);
            this.rePasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rePasswordTextBox.MaxLength = 32767;
            this.rePasswordTextBox.Name = "rePasswordTextBox";
            this.rePasswordTextBox.Size = new System.Drawing.Size(362, 33);
            this.rePasswordTextBox.TabIndex = 9;
            this.rePasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RePasswordLabel
            // 
            this.RePasswordLabel.AutoSize = true;
            this.RePasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.RePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.RePasswordLabel.Location = new System.Drawing.Point(13, 296);
            this.RePasswordLabel.Name = "RePasswordLabel";
            this.RePasswordLabel.Size = new System.Drawing.Size(156, 21);
            this.RePasswordLabel.TabIndex = 8;
            this.RePasswordLabel.Text = "Re-Enter Password:";
            this.RePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextBox.HintText = "Your Password";
            this.passwordTextBox.isPassword = true;
            this.passwordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.passwordTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.passwordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.passwordTextBox.LineThickness = 3;
            this.passwordTextBox.Location = new System.Drawing.Point(17, 243);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(362, 33);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.PasswordLabel.Location = new System.Drawing.Point(13, 218);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerNmTextBox
            // 
            this.playerNmTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.playerNmTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.playerNmTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.playerNmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.playerNmTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.playerNmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playerNmTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.playerNmTextBox.HintText = "Player Nickname";
            this.playerNmTextBox.isPassword = false;
            this.playerNmTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.playerNmTextBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.playerNmTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.playerNmTextBox.LineThickness = 3;
            this.playerNmTextBox.Location = new System.Drawing.Point(17, 167);
            this.playerNmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerNmTextBox.MaxLength = 32767;
            this.playerNmTextBox.Name = "playerNmTextBox";
            this.playerNmTextBox.Size = new System.Drawing.Size(362, 33);
            this.playerNmTextBox.TabIndex = 5;
            this.playerNmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.UserNameLabel.Location = new System.Drawing.Point(13, 142);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(98, 21);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "User Name:";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.RegisterLabel.Location = new System.Drawing.Point(12, 99);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(107, 30);
            this.RegisterLabel.TabIndex = 3;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button regiserButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTextbox;
        private System.Windows.Forms.Label EmailLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rePasswordTextBox;
        private System.Windows.Forms.Label RePasswordLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox playerNmTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label alredyHaveLabel;
        private System.Windows.Forms.Panel signUpPanel;
        private System.Windows.Forms.Label createAccLabel;
        private Bunifu.UI.WinForms.BunifuImageButton closeBtnLog;
        private System.Windows.Forms.Button signUpButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox logPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox logPlayerNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SignUpLabel;
    }
}

