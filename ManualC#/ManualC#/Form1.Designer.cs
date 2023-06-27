namespace ManualC_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleList = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.GunaInfoLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GunaLoginMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaRegistationMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaErrorLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GunaCreateLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaCreateAccountButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.GunaCreatePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaBackToAuthorizationButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GunaAuthorizationMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaLoginButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GunaLoginLabel = new System.Windows.Forms.Label();
            this.GunaPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.GunaAddUserButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GunaUpPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaWindowScaleButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GunaCloseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GunaFavoriteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LeftBar = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaColorTransition = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.qvScrollBar1 = new ManualC_.QVScrollBar();
            this.TitleList.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.GunaLoginMenu.SuspendLayout();
            this.GunaRegistationMenu.SuspendLayout();
            this.GunaAuthorizationMenu.SuspendLayout();
            this.GunaUpPanel.SuspendLayout();
            this.LeftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleList
            // 
            this.TitleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleList.BackColor = System.Drawing.Color.Transparent;
            this.TitleList.BorderColor = System.Drawing.Color.Black;
            this.TitleList.Controls.Add(this.qvScrollBar1);
            this.TitleList.Location = new System.Drawing.Point(3, 52);
            this.TitleList.Name = "TitleList";
            this.TitleList.ShadowDecoration.Depth = 15;
            this.TitleList.ShadowDecoration.Enabled = true;
            this.TitleList.Size = new System.Drawing.Size(203, 563);
            this.TitleList.TabIndex = 10;
            // 
            // GunaSearchBar
            // 
            this.GunaSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GunaSearchBar.BorderColor = System.Drawing.Color.Silver;
            this.GunaSearchBar.BorderRadius = 5;
            this.GunaSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaSearchBar.DefaultText = "Поиск";
            this.GunaSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaSearchBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaSearchBar.IconLeft = ((System.Drawing.Image)(resources.GetObject("GunaSearchBar.IconLeft")));
            this.GunaSearchBar.IconLeftOffset = new System.Drawing.Point(0, 1);
            this.GunaSearchBar.IconLeftSize = new System.Drawing.Size(32, 32);
            this.GunaSearchBar.Location = new System.Drawing.Point(3, 622);
            this.GunaSearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GunaSearchBar.Name = "GunaSearchBar";
            this.GunaSearchBar.PasswordChar = '\0';
            this.GunaSearchBar.PlaceholderText = "";
            this.GunaSearchBar.SelectedText = "";
            this.GunaSearchBar.Size = new System.Drawing.Size(203, 47);
            this.GunaSearchBar.TabIndex = 9;
            this.GunaSearchBar.Enter += new System.EventHandler(this.GunaSearchBar_Enter);
            this.GunaSearchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GunaSearchBar_KeyUp);
            this.GunaSearchBar.Leave += new System.EventHandler(this.GunaSearchBar_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "C# Manual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.Controls.Add(this.GunaInfoLabel);
            this.guna2GradientPanel1.Controls.Add(this.GunaLoginMenu);
            this.guna2GradientPanel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(216, 52);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 3;
            this.guna2GradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1046, 621);
            this.guna2GradientPanel1.TabIndex = 10;
            // 
            // GunaInfoLabel
            // 
            this.GunaInfoLabel.AutoSize = false;
            this.GunaInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GunaInfoLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaInfoLabel.ForeColor = System.Drawing.Color.White;
            this.GunaInfoLabel.Location = new System.Drawing.Point(630, 559);
            this.GunaInfoLabel.Name = "GunaInfoLabel";
            this.GunaInfoLabel.Size = new System.Drawing.Size(269, 62);
            this.GunaInfoLabel.TabIndex = 3;
            this.GunaInfoLabel.Text = resources.GetString("GunaInfoLabel.Text");
            this.GunaInfoLabel.Visible = false;
            // 
            // GunaLoginMenu
            // 
            this.GunaLoginMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GunaLoginMenu.BackColor = System.Drawing.Color.Transparent;
            this.GunaLoginMenu.BorderRadius = 5;
            this.GunaLoginMenu.Controls.Add(this.GunaAuthorizationMenu);
            this.GunaLoginMenu.Controls.Add(this.GunaRegistationMenu);
            this.GunaLoginMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.GunaLoginMenu.Location = new System.Drawing.Point(377, 207);
            this.GunaLoginMenu.Name = "GunaLoginMenu";
            this.GunaLoginMenu.ShadowDecoration.BorderRadius = 3;
            this.GunaLoginMenu.ShadowDecoration.Enabled = true;
            this.GunaLoginMenu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.GunaLoginMenu.Size = new System.Drawing.Size(308, 198);
            this.GunaLoginMenu.TabIndex = 2;
            // 
            // GunaRegistationMenu
            // 
            this.GunaRegistationMenu.Controls.Add(this.GunaErrorLabel);
            this.GunaRegistationMenu.Controls.Add(this.GunaCreateLogin);
            this.GunaRegistationMenu.Controls.Add(this.GunaCreateAccountButton);
            this.GunaRegistationMenu.Controls.Add(this.label2);
            this.GunaRegistationMenu.Controls.Add(this.GunaCreatePassword);
            this.GunaRegistationMenu.Controls.Add(this.GunaBackToAuthorizationButton);
            this.GunaRegistationMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaRegistationMenu.Location = new System.Drawing.Point(0, 0);
            this.GunaRegistationMenu.Name = "GunaRegistationMenu";
            this.GunaRegistationMenu.Size = new System.Drawing.Size(308, 198);
            this.GunaRegistationMenu.TabIndex = 12;
            // 
            // GunaErrorLabel
            // 
            this.GunaErrorLabel.AutoSize = false;
            this.GunaErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.GunaErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaErrorLabel.ForeColor = System.Drawing.Color.White;
            this.GunaErrorLabel.Location = new System.Drawing.Point(61, 150);
            this.GunaErrorLabel.Name = "GunaErrorLabel";
            this.GunaErrorLabel.Size = new System.Drawing.Size(172, 43);
            this.GunaErrorLabel.TabIndex = 12;
            this.GunaErrorLabel.Text = "Такой аккаунт уже существует <img src=\"warning.png\" width=\"20\" height=\"20\">\r\n";
            this.GunaErrorLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.GunaErrorLabel.Visible = false;
            // 
            // GunaCreateLogin
            // 
            this.GunaCreateLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaCreateLogin.BorderRadius = 5;
            this.GunaCreateLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaCreateLogin.DefaultText = "Логин";
            this.GunaCreateLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaCreateLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaCreateLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaCreateLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaCreateLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaCreateLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaCreateLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaCreateLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("GunaCreateLogin.IconLeft")));
            this.GunaCreateLogin.Location = new System.Drawing.Point(3, 54);
            this.GunaCreateLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GunaCreateLogin.Name = "GunaCreateLogin";
            this.GunaCreateLogin.PasswordChar = '\0';
            this.GunaCreateLogin.PlaceholderText = "";
            this.GunaCreateLogin.SelectedText = "";
            this.GunaCreateLogin.Size = new System.Drawing.Size(301, 36);
            this.GunaCreateLogin.TabIndex = 1;
            this.GunaCreateLogin.Enter += new System.EventHandler(this.GunaCreateLogin_Enter);
            this.GunaCreateLogin.Leave += new System.EventHandler(this.GunaCreateLogin_Leave);
            // 
            // GunaCreateAccountButton
            // 
            this.GunaCreateAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaCreateAccountButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaCreateAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaCreateAccountButton.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaCreateAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaCreateAccountButton.Image")));
            this.GunaCreateAccountButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaCreateAccountButton.ImageRotate = 0F;
            this.GunaCreateAccountButton.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaCreateAccountButton.Location = new System.Drawing.Point(252, 141);
            this.GunaCreateAccountButton.Name = "GunaCreateAccountButton";
            this.GunaCreateAccountButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaCreateAccountButton.Size = new System.Drawing.Size(52, 52);
            this.GunaCreateAccountButton.TabIndex = 3;
            this.GunaCreateAccountButton.Click += new System.EventHandler(this.GunaCreateAccountButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(3, -4);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(301, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Регистрация";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GunaCreatePassword
            // 
            this.GunaCreatePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaCreatePassword.BorderRadius = 5;
            this.GunaCreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaCreatePassword.DefaultText = "Пароль";
            this.GunaCreatePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaCreatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaCreatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaCreatePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaCreatePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaCreatePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaCreatePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaCreatePassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("GunaCreatePassword.IconLeft")));
            this.GunaCreatePassword.Location = new System.Drawing.Point(3, 98);
            this.GunaCreatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GunaCreatePassword.Name = "GunaCreatePassword";
            this.GunaCreatePassword.PasswordChar = '\0';
            this.GunaCreatePassword.PlaceholderText = "";
            this.GunaCreatePassword.SelectedText = "";
            this.GunaCreatePassword.Size = new System.Drawing.Size(301, 36);
            this.GunaCreatePassword.TabIndex = 6;
            this.GunaCreatePassword.Enter += new System.EventHandler(this.GunaCreatePassword_Enter);
            this.GunaCreatePassword.Leave += new System.EventHandler(this.GunaCreatePassword_Leave);
            // 
            // GunaBackToAuthorizationButton
            // 
            this.GunaBackToAuthorizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaBackToAuthorizationButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaBackToAuthorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaBackToAuthorizationButton.HoverState.ImageSize = new System.Drawing.Size(84, 84);
            this.GunaBackToAuthorizationButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaBackToAuthorizationButton.Image")));
            this.GunaBackToAuthorizationButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaBackToAuthorizationButton.ImageRotate = 0F;
            this.GunaBackToAuthorizationButton.ImageSize = new System.Drawing.Size(84, 84);
            this.GunaBackToAuthorizationButton.Location = new System.Drawing.Point(3, 141);
            this.GunaBackToAuthorizationButton.Name = "GunaBackToAuthorizationButton";
            this.GunaBackToAuthorizationButton.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.GunaBackToAuthorizationButton.Size = new System.Drawing.Size(52, 52);
            this.GunaBackToAuthorizationButton.TabIndex = 9;
            this.GunaBackToAuthorizationButton.Click += new System.EventHandler(this.GunaBackToAuthorizationButton_Click);
            // 
            // GunaAuthorizationMenu
            // 
            this.GunaAuthorizationMenu.Controls.Add(this.GunaLogin);
            this.GunaAuthorizationMenu.Controls.Add(this.GunaLoginButton);
            this.GunaAuthorizationMenu.Controls.Add(this.GunaLoginLabel);
            this.GunaAuthorizationMenu.Controls.Add(this.GunaPassword);
            this.GunaAuthorizationMenu.Controls.Add(this.GunaAddUserButton);
            this.GunaAuthorizationMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaAuthorizationMenu.Location = new System.Drawing.Point(0, 0);
            this.GunaAuthorizationMenu.Name = "GunaAuthorizationMenu";
            this.GunaAuthorizationMenu.Size = new System.Drawing.Size(308, 198);
            this.GunaAuthorizationMenu.TabIndex = 11;
            this.GunaAuthorizationMenu.Visible = false;
            // 
            // GunaLogin
            // 
            this.GunaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaLogin.BorderRadius = 5;
            this.GunaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaLogin.DefaultText = "Логин";
            this.GunaLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("GunaLogin.IconLeft")));
            this.GunaLogin.Location = new System.Drawing.Point(3, 54);
            this.GunaLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GunaLogin.Name = "GunaLogin";
            this.GunaLogin.PasswordChar = '\0';
            this.GunaLogin.PlaceholderText = "";
            this.GunaLogin.SelectedText = "";
            this.GunaLogin.Size = new System.Drawing.Size(301, 36);
            this.GunaLogin.TabIndex = 1;
            this.GunaLogin.Enter += new System.EventHandler(this.GunaLogin_Enter);
            this.GunaLogin.Leave += new System.EventHandler(this.GunaLogin_Leave);
            // 
            // GunaLoginButton
            // 
            this.GunaLoginButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaLoginButton.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaLoginButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaLoginButton.Image")));
            this.GunaLoginButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaLoginButton.ImageRotate = 0F;
            this.GunaLoginButton.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaLoginButton.Location = new System.Drawing.Point(252, 141);
            this.GunaLoginButton.Name = "GunaLoginButton";
            this.GunaLoginButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaLoginButton.Size = new System.Drawing.Size(52, 52);
            this.GunaLoginButton.TabIndex = 3;
            this.GunaLoginButton.Click += new System.EventHandler(this.GunaLoginButton_Click);
            // 
            // GunaLoginLabel
            // 
            this.GunaLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaLoginLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLoginLabel.ForeColor = System.Drawing.Color.White;
            this.GunaLoginLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GunaLoginLabel.Location = new System.Drawing.Point(3, -4);
            this.GunaLoginLabel.Name = "GunaLoginLabel";
            this.GunaLoginLabel.Size = new System.Drawing.Size(301, 54);
            this.GunaLoginLabel.TabIndex = 5;
            this.GunaLoginLabel.Text = "Авторизация";
            this.GunaLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GunaPassword
            // 
            this.GunaPassword.BorderRadius = 5;
            this.GunaPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GunaPassword.DefaultText = "Пароль";
            this.GunaPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GunaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GunaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GunaPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GunaPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("GunaPassword.IconLeft")));
            this.GunaPassword.Location = new System.Drawing.Point(3, 98);
            this.GunaPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GunaPassword.Name = "GunaPassword";
            this.GunaPassword.PasswordChar = '\0';
            this.GunaPassword.PlaceholderText = "";
            this.GunaPassword.SelectedText = "";
            this.GunaPassword.Size = new System.Drawing.Size(301, 36);
            this.GunaPassword.TabIndex = 6;
            this.GunaPassword.Enter += new System.EventHandler(this.GunaPassword_Enter);
            this.GunaPassword.Leave += new System.EventHandler(this.GunaPassword_Leave);
            // 
            // GunaAddUserButton
            // 
            this.GunaAddUserButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaAddUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaAddUserButton.HoverState.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaAddUserButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaAddUserButton.Image")));
            this.GunaAddUserButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaAddUserButton.ImageRotate = 0F;
            this.GunaAddUserButton.ImageSize = new System.Drawing.Size(52, 52);
            this.GunaAddUserButton.Location = new System.Drawing.Point(3, 141);
            this.GunaAddUserButton.Name = "GunaAddUserButton";
            this.GunaAddUserButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaAddUserButton.Size = new System.Drawing.Size(52, 52);
            this.GunaAddUserButton.TabIndex = 9;
            this.GunaAddUserButton.Click += new System.EventHandler(this.GunaAddUserButton_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DateTimePicker1.BorderRadius = 5;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(905, 582);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(138, 36);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.Value = new System.DateTime(2023, 6, 27, 0, 46, 45, 714);
            // 
            // GunaUpPanel
            // 
            this.GunaUpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.GunaUpPanel.BorderColor = System.Drawing.Color.Black;
            this.GunaUpPanel.BorderRadius = 5;
            this.GunaUpPanel.Controls.Add(this.GunaWindowScaleButton);
            this.GunaUpPanel.Controls.Add(this.guna2ImageButton3);
            this.GunaUpPanel.Controls.Add(this.GunaCloseButton);
            this.GunaUpPanel.Controls.Add(this.guna2ImageButton2);
            this.GunaUpPanel.Controls.Add(this.guna2ImageButton1);
            this.GunaUpPanel.Controls.Add(this.GunaFavoriteButton);
            this.GunaUpPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GunaUpPanel.Location = new System.Drawing.Point(216, 0);
            this.GunaUpPanel.Name = "GunaUpPanel";
            this.GunaUpPanel.ShadowDecoration.BorderRadius = 3;
            this.GunaUpPanel.ShadowDecoration.Enabled = true;
            this.GunaUpPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.GunaUpPanel.Size = new System.Drawing.Size(1046, 49);
            this.GunaUpPanel.TabIndex = 7;
            this.GunaUpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GunaUpPanel_MouseDown);
            // 
            // GunaWindowScaleButton
            // 
            this.GunaWindowScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaWindowScaleButton.BackColor = System.Drawing.Color.Transparent;
            this.GunaWindowScaleButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaWindowScaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaWindowScaleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GunaWindowScaleButton.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaWindowScaleButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaWindowScaleButton.Image")));
            this.GunaWindowScaleButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaWindowScaleButton.ImageRotate = 0F;
            this.GunaWindowScaleButton.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaWindowScaleButton.Location = new System.Drawing.Point(953, 3);
            this.GunaWindowScaleButton.Name = "GunaWindowScaleButton";
            this.GunaWindowScaleButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaWindowScaleButton.ShadowDecoration.BorderRadius = 2;
            this.GunaWindowScaleButton.ShadowDecoration.Depth = 15;
            this.GunaWindowScaleButton.Size = new System.Drawing.Size(42, 42);
            this.GunaWindowScaleButton.TabIndex = 29;
            this.GunaWindowScaleButton.Click += new System.EventHandler(this.GunaWindowScaleButton_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.Location = new System.Drawing.Point(51, 3);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton3.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton3.ShadowDecoration.Depth = 15;
            this.guna2ImageButton3.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.TabIndex = 28;
            // 
            // GunaCloseButton
            // 
            this.GunaCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.GunaCloseButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaCloseButton.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaCloseButton.Image")));
            this.GunaCloseButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaCloseButton.ImageRotate = 0F;
            this.GunaCloseButton.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaCloseButton.Location = new System.Drawing.Point(1001, 3);
            this.GunaCloseButton.Name = "GunaCloseButton";
            this.GunaCloseButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaCloseButton.ShadowDecoration.BorderRadius = 2;
            this.GunaCloseButton.ShadowDecoration.Depth = 15;
            this.GunaCloseButton.Size = new System.Drawing.Size(42, 42);
            this.GunaCloseButton.TabIndex = 27;
            this.GunaCloseButton.Click += new System.EventHandler(this.GunaCloseButton_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Location = new System.Drawing.Point(99, 3);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton2.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton2.ShadowDecoration.Depth = 15;
            this.guna2ImageButton2.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.TabIndex = 26;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(147, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton1.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton1.ShadowDecoration.Depth = 15;
            this.guna2ImageButton1.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.TabIndex = 25;
            // 
            // GunaFavoriteButton
            // 
            this.GunaFavoriteButton.BackColor = System.Drawing.Color.Transparent;
            this.GunaFavoriteButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.GunaFavoriteButton.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.GunaFavoriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaFavoriteButton.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaFavoriteButton.Image = ((System.Drawing.Image)(resources.GetObject("GunaFavoriteButton.Image")));
            this.GunaFavoriteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.GunaFavoriteButton.ImageRotate = 0F;
            this.GunaFavoriteButton.ImageSize = new System.Drawing.Size(42, 42);
            this.GunaFavoriteButton.Location = new System.Drawing.Point(3, 3);
            this.GunaFavoriteButton.Name = "GunaFavoriteButton";
            this.GunaFavoriteButton.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.GunaFavoriteButton.ShadowDecoration.BorderRadius = 2;
            this.GunaFavoriteButton.ShadowDecoration.Depth = 15;
            this.GunaFavoriteButton.Size = new System.Drawing.Size(42, 42);
            this.GunaFavoriteButton.TabIndex = 24;
            this.GunaFavoriteButton.Click += new System.EventHandler(this.GunaFavoriteButton_Click);
            // 
            // LeftBar
            // 
            this.LeftBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBar.BackColor = System.Drawing.Color.Transparent;
            this.LeftBar.BorderRadius = 5;
            this.LeftBar.Controls.Add(this.label1);
            this.LeftBar.Controls.Add(this.GunaSearchBar);
            this.LeftBar.Controls.Add(this.TitleList);
            this.LeftBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.ShadowDecoration.BorderRadius = 3;
            this.LeftBar.ShadowDecoration.Enabled = true;
            this.LeftBar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.LeftBar.Size = new System.Drawing.Size(213, 673);
            this.LeftBar.TabIndex = 1;
            // 
            // GunaColorTransition
            // 
            this.GunaColorTransition.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(105))))),
        System.Drawing.Color.Black};
            this.GunaColorTransition.EndColor = System.Drawing.Color.Black;
            this.GunaColorTransition.Interval = 1;
            this.GunaColorTransition.StartColor = System.Drawing.Color.Black;
            this.GunaColorTransition.ValueChanged += new System.EventHandler(this.GunaColorTransition_ValueChanged);
            // 
            // qvScrollBar1
            // 
            this.qvScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qvScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.qvScrollBar1.ContentContainer = this.TitleList;
            this.qvScrollBar1.Location = new System.Drawing.Point(183, 3);
            this.qvScrollBar1.Name = "qvScrollBar1";
            this.qvScrollBar1.Size = new System.Drawing.Size(17, 557);
            this.qvScrollBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.GunaUpPanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.LeftBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "C# Manual";
            this.TitleList.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.GunaLoginMenu.ResumeLayout(false);
            this.GunaRegistationMenu.ResumeLayout(false);
            this.GunaAuthorizationMenu.ResumeLayout(false);
            this.GunaUpPanel.ResumeLayout(false);
            this.LeftBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel GunaUpPanel;
        private Guna.UI2.WinForms.Guna2ImageButton GunaFavoriteButton;
        private Guna.UI2.WinForms.Guna2TextBox GunaSearchBar;
        private Guna.UI2.WinForms.Guna2Panel TitleList;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private QVScrollBar qvScrollBar1;
        private Guna.UI2.WinForms.Guna2ImageButton GunaCloseButton;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel LeftBar;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Panel GunaLoginMenu;
        private System.Windows.Forms.Label GunaLoginLabel;
        private Guna.UI2.WinForms.Guna2ImageButton GunaLoginButton;
        private Guna.UI2.WinForms.Guna2TextBox GunaLogin;
        private Guna.UI2.WinForms.Guna2TextBox GunaPassword;
        private Guna.UI2.WinForms.Guna2ImageButton GunaAddUserButton;
        private Guna.UI2.WinForms.Guna2Panel GunaAuthorizationMenu;
        private Guna.UI2.WinForms.Guna2Panel GunaRegistationMenu;
        private Guna.UI2.WinForms.Guna2TextBox GunaCreateLogin;
        private Guna.UI2.WinForms.Guna2ImageButton GunaCreateAccountButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox GunaCreatePassword;
        private Guna.UI2.WinForms.Guna2ImageButton GunaBackToAuthorizationButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel GunaInfoLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton GunaWindowScaleButton;
        private Guna.UI2.WinForms.Guna2ColorTransition GunaColorTransition;
        private Guna.UI2.WinForms.Guna2HtmlLabel GunaErrorLabel;
    }
}

