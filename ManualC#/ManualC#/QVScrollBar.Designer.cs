namespace ManualC_
{
    partial class QVScrollBar
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
            this.Toggle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toggle
            // 
            this.Toggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Toggle.BackColor = System.Drawing.Color.Transparent;
            this.Toggle.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Toggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Toggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Toggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Toggle.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Toggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Toggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(124)))));
            this.Toggle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.Toggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toggle.ForeColor = System.Drawing.Color.Wheat;
            this.Toggle.Location = new System.Drawing.Point(0, 0);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(26, 142);
            this.Toggle.TabIndex = 3;
            this.Toggle.Text = "2";
            this.Toggle.Enter += new System.EventHandler(this.Toggle_Enter);
            this.Toggle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toggle_MouseDown);
            this.Toggle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toggle_MouseMove);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderColor = System.Drawing.Color.Black;
            this.Panel.BorderRadius = 2;
            this.Panel.Controls.Add(this.Toggle);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.FillColor = System.Drawing.Color.Gainsboro;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(-5);
            this.Panel.Size = new System.Drawing.Size(26, 539);
            this.Panel.TabIndex = 4;
            // 
            // QVScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Name = "QVScrollBar";
            this.Size = new System.Drawing.Size(26, 539);
            this.ParentChanged += new System.EventHandler(this.QVScrollBar_ParentChanged);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Toggle;
        private Guna.UI2.WinForms.Guna2Panel Panel;
    }
}
