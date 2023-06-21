namespace ManualC_
{
    partial class TitleButtonPrefab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GunaTitlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaTitleButton = new Guna.UI2.WinForms.Guna2Button();
            this.GunaTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaTitlePanel
            // 
            this.GunaTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.GunaTitlePanel.BorderColor = System.Drawing.Color.Black;
            this.GunaTitlePanel.BorderRadius = 15;
            this.GunaTitlePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.GunaTitlePanel.BorderThickness = 2;
            this.GunaTitlePanel.Controls.Add(this.GunaTitleButton);
            this.GunaTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaTitlePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GunaTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.GunaTitlePanel.Name = "GunaTitlePanel";
            this.GunaTitlePanel.ShadowDecoration.BorderRadius = 10;
            this.GunaTitlePanel.ShadowDecoration.Depth = 10;
            this.GunaTitlePanel.ShadowDecoration.Enabled = true;
            this.GunaTitlePanel.Size = new System.Drawing.Size(175, 31);
            this.GunaTitlePanel.TabIndex = 7;
            // 
            // GunaTitleButton
            // 
            this.GunaTitleButton.BorderRadius = 5;
            this.GunaTitleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaTitleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaTitleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaTitleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaTitleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaTitleButton.FillColor = System.Drawing.Color.Transparent;
            this.GunaTitleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaTitleButton.ForeColor = System.Drawing.SystemColors.Window;
            this.GunaTitleButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.GunaTitleButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GunaTitleButton.Location = new System.Drawing.Point(0, 0);
            this.GunaTitleButton.Name = "GunaTitleButton";
            this.GunaTitleButton.ShadowDecoration.Enabled = true;
            this.GunaTitleButton.Size = new System.Drawing.Size(175, 31);
            this.GunaTitleButton.TabIndex = 0;
            this.GunaTitleButton.Text = "Операторы";
            this.GunaTitleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GunaTitleButton_MouseClick);
            // 
            // TitleButtonPrefab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GunaTitlePanel);
            this.Name = "TitleButtonPrefab";
            this.Size = new System.Drawing.Size(175, 31);
            this.GunaTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel GunaTitlePanel;
        private Guna.UI2.WinForms.Guna2Button GunaTitleButton;
    }
}
