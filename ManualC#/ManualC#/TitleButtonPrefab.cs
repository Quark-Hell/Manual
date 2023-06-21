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

        public TitleButtonPrefab()
        {
            InitializeComponent();
        }

        private void GunaTitleButton_MouseClick(object sender, MouseEventArgs e)
        {
            Browser.Navigate(new Uri(path));
        }
    }
}
