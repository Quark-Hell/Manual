using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualC_
{
    public partial class TitleButtonPrefab : UserControl
    {
        public QVScrollBar Scrollbar;
        public Guna2GradientButton Button { get; private set; }

        public string Text { get; private set; }

        public TitleButtonPrefab()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            Button = GunaTitleButton;
        }

        public void SetText(string text)
        {
            Text = text;
            GunaTitleButton.Text = text;
        }
    }
}
