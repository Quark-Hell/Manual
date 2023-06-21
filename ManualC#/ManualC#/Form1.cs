using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManualC_
{
    public partial class Form1 : Form
    {
        List<Chapter> chapters = new List<Chapter>();

        public Form1()
        {
            InitializeComponent();

            string pagesPath = AppDomain.CurrentDomain.BaseDirectory + "Pages";

            chapters.Add(new Chapter("Методы", new string[] { "именованный", "блок", "метод", "вызов", "повторно" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Операторы", new string[] { "умножить", "делить", "сумма", "разность", "произведение" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Массивы", new string[] { "однотипный", "набор", "данных", "индексы", "многомерные", "двумерные" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));

            InitTitleList();
        }

        private void InitTitleList()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                chapters[i].SetParent(TitleList);
                chapters[i].SetControl(new TitleButtonPrefab(), webBrowser1);
                chapters[i].SetLocation(new Point(3, i * 35));

                chapters[i].AddLocation(new Point(0, 3));
            }

            //ManualList.Items.Clear();
            //for (int i = 0; i < chapters.Count; i++)
            //{
            //    ManualList.Items.Add(chapters[i].Name);
            //}
        }

        private List<string> SearchMatch(string searchWord)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < chapters.Count; i++)
            {
                //if name similar searchWord
                if (chapters[i].Name.IndexOf(searchWord, 0, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    output.Add(chapters[i].Name);
                    continue;
                }
                for (int j = 0; j < chapters[i].Tags.Length; j++)
                {
                    //if tag similar searchWord
                    if (chapters[i].Tags[j].IndexOf(searchWord, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        output.Add(chapters[i].Name);
                        break;
                    }
                }
            }

            return output;
        }

        private void ManualList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                //if (ManualList.SelectedItem.ToString() == chapters[i].Name)
                //{
                //    webBrowser1.Navigate(new Uri(chapters[i].PathToFile));
                //    break;
                //}
            }
        }

        private void GunaSearchBar_Leave(object sender, EventArgs e)
        {
            if (GunaSearchBar.Text == "")
            {
                GunaSearchBar.ForeColor = Color.Gray;
                GunaSearchBar.Text = "Поиск";

                InitTitleList();
            }
        }

        private void GunaSearchBar_Enter(object sender, EventArgs e)
        {
            GunaSearchBar.ForeColor = Color.Black;
            GunaSearchBar.Text = "";
            InitTitleList();
        }

        private void GunaSearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            InitTitleList();
            if (GunaSearchBar.Text != "")
            {
                List<string> matches = SearchMatch(GunaSearchBar.Text);

                //for (int i = 0; i < ManualList.Items.Count; i++)
                //{
                //    bool isHave = false;
                //    for (int j = 0; j < matches.Count; j++)
                //    {
                //        // if (ManualList.Items[i].ToString() == matches[j])
                //        // {
                //        //     isHave = true;
                //        //     break;
                //        // }
                //    }
                //
                //    if (isHave == false)
                //    {
                //        //ManualList.Items.RemoveAt(i);
                //        i--;
                //    }
                //}
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }

    public class Chapter
    {
        public string Name { get; private set; }
        public string[] Tags;

        public string PathToFile { get; private set; }

        private Control Parent;
        private TitleButtonPrefab TitlePanel;

        public Chapter(string name, string[] tags, string pathToFile)
        {
            Name = name;
            Tags = new string[tags.Length];
            Array.Copy(tags, Tags, tags.Length);

            PathToFile = pathToFile;
        }

        public void SetParent(Control parent)
        {
            Parent = parent;

            if (TitlePanel != null)
            {
                parent.Controls.Add(TitlePanel);
            }
        }

        public void SetControl(TitleButtonPrefab titlePanel, WebBrowser browser)
        {
            TitlePanel = titlePanel;

            TitlePanel.Browser = browser;
            TitlePanel.path = PathToFile;

            var aoControls = TitlePanel.Controls.Find("GunaTitleButton", true);
            if ((aoControls != null) && (aoControls.Length != 0))
            {
                Control foundControl = aoControls[0];
                foundControl.Text = Name;
            }
        }

        public void SetLocation(Point newLoc)
        {
            if (TitlePanel != null)
            {
                TitlePanel.Location = newLoc;
            }
        }

        public void AddLocation(Point newLoc)
        {
            if (TitlePanel != null)
            {
                TitlePanel.Location = new Point(TitlePanel.Location.X + newLoc.X, TitlePanel.Location.Y + newLoc.Y);
            }
        }
    }
}
