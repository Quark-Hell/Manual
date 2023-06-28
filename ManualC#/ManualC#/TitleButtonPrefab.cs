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
        public Guna2HtmlLabel Label;
        public string Path;

        public string Text { get; private set; }

        public TitleButtonPrefab(Guna2HtmlLabel label, string path)
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            Label = label;
            Path = path;
        }

        public void SetText(string text)
        {
            Text = text;
            GunaTitleButton.Text = text;
        }

        private void GunaTitleButton_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                if (Label != null)
                {
                    string text = reader.ReadToEnd();
                    Label.Text = text;

                    Scrollbar.ContentContainer.Visible = true;
                    Scrollbar.SetScrollbarParameters();
                }
            }
        }
    }
}
