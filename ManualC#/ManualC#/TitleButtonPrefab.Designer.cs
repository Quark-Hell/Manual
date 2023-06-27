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
            this.GunaTitleButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // GunaTitleButton
            // 
            this.GunaTitleButton.BorderRadius = 3;
            this.GunaTitleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaTitleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GunaTitleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GunaTitleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaTitleButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GunaTitleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GunaTitleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaTitleButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.GunaTitleButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.GunaTitleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaTitleButton.ForeColor = System.Drawing.Color.White;
            this.GunaTitleButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GunaTitleButton.HoverState.ForeColor = System.Drawing.Color.Gold;
            this.GunaTitleButton.Location = new System.Drawing.Point(0, 0);
            this.GunaTitleButton.Name = "GunaTitleButton";
            this.GunaTitleButton.Size = new System.Drawing.Size(178, 31);
            this.GunaTitleButton.TabIndex = 0;
            this.GunaTitleButton.Text = "guna2GradientButton1";
            this.GunaTitleButton.Click += new System.EventHandler(this.GunaTitleButton_Click);
            // 
            // TitleButtonPrefab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GunaTitleButton);
            this.Name = "TitleButtonPrefab";
            this.Size = new System.Drawing.Size(178, 31);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton GunaTitleButton;
    }
}
