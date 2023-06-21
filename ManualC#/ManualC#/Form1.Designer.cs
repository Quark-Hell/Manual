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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.TitleList = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.GunaWebPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.GunaWebPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.guna2VScrollBar2);
            this.panel2.Controls.Add(this.TitleList);
            this.panel2.Controls.Add(this.GunaSearchBar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 673);
            this.panel2.TabIndex = 2;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar2.BackColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar2.BindingContainer = this.TitleList;
            this.guna2VScrollBar2.BorderColor = System.Drawing.Color.Black;
            this.guna2VScrollBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2VScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2VScrollBar2.FillColor = System.Drawing.Color.White;
            this.guna2VScrollBar2.HighlightOnWheel = true;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(185, 55);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.PressedState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(70)))));
            this.guna2VScrollBar2.ScrollbarSize = 19;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(21, 560);
            this.guna2VScrollBar2.TabIndex = 11;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.guna2VScrollBar2.ThumbSize = 15F;
            this.guna2VScrollBar2.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // TitleList
            // 
            this.TitleList.AutoScroll = true;
            this.TitleList.BackColor = System.Drawing.Color.Transparent;
            this.TitleList.BorderColor = System.Drawing.Color.Black;
            this.TitleList.BorderThickness = 1;
            this.TitleList.Location = new System.Drawing.Point(3, 55);
            this.TitleList.Name = "TitleList";
            this.TitleList.ShadowDecoration.Depth = 15;
            this.TitleList.ShadowDecoration.Enabled = true;
            this.TitleList.Size = new System.Drawing.Size(203, 560);
            this.TitleList.TabIndex = 10;
            // 
            // GunaSearchBar
            // 
            this.GunaSearchBar.BorderColor = System.Drawing.Color.Silver;
            this.GunaSearchBar.BorderRadius = 15;
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
            this.GunaSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GunaSearchBar_KeyPress);
            this.GunaSearchBar.Leave += new System.EventHandler(this.GunaSearchBar_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "C# Manual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.GunaWebPanel);
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 673);
            this.panel1.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.guna2ImageButton3);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1043, 50);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.Location = new System.Drawing.Point(3, 3);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton3.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton3.ShadowDecoration.Depth = 15;
            this.guna2ImageButton3.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton3.TabIndex = 24;
            // 
            // GunaWebPanel
            // 
            this.GunaWebPanel.BackColor = System.Drawing.Color.Transparent;
            this.GunaWebPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GunaWebPanel.Controls.Add(this.webBrowser1);
            this.GunaWebPanel.FillColor = System.Drawing.Color.White;
            this.GunaWebPanel.Location = new System.Drawing.Point(3, 54);
            this.GunaWebPanel.Name = "GunaWebPanel";
            this.GunaWebPanel.ShadowColor = System.Drawing.Color.Black;
            this.GunaWebPanel.ShadowShift = 0;
            this.GunaWebPanel.Size = new System.Drawing.Size(1040, 616);
            this.GunaWebPanel.TabIndex = 9;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1038, 614);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(997, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton1.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton1.ShadowDecoration.Depth = 15;
            this.guna2ImageButton1.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.TabIndex = 25;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.Location = new System.Drawing.Point(950, 5);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton2.ShadowDecoration.BorderRadius = 2;
            this.guna2ImageButton2.ShadowDecoration.Depth = 15;
            this.guna2ImageButton2.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton2.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C# Manual";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.GunaWebPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2ShadowPanel GunaWebPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2TextBox GunaSearchBar;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private Guna.UI2.WinForms.Guna2Panel TitleList;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

