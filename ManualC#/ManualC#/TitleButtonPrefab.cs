using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualC_
{
    public partial class TitleButtonPrefab : UserControl
    {
        public WebBrowser Browser;
        public string path;

        public string Text { get; private set; }

        public TitleButtonPrefab()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);
        }

        public void SetText(string text)
        {
            Text = text;
            GunaTitleButton.Text = text;
        }

        private void GunaTitleButton_Click(object sender, EventArgs e)
        {
            Browser.Navigate(new Uri(path));
        }
    }
}
