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
        }

        protected override void OnLoad(EventArgs e)
        {
            string pagesPath = AppDomain.CurrentDomain.BaseDirectory + "Pages";

            chapters.Add(new Chapter("Методы", new string[] { "именованный", "блок", "метод", "вызов", "повторно" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Операторы", new string[] { "умножить", "делить", "сумма", "разность", "произведение" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Массивы", new string[] { "однотипный", "набор", "данных", "индексы", "многомерные", "двумерные" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));
            chapters.Add(new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));

            InitScrollBar();
            qvScrollBar1.SetScrollbarParameters();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            SetDoubleBuffered(TitleList);

            base.OnLoad(e);
        }

        private void InitScrollBar()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                TitleButtonPrefab button = new TitleButtonPrefab();
                button.Location = new Point(3, button.Location.Y);
                button.SetText(chapters[i].Name);

                qvScrollBar1.AddControl(button);
            }
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
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
            }
        }

        private void GunaSearchBar_Enter(object sender, EventArgs e)
        {
            GunaSearchBar.ForeColor = Color.Black;
            GunaSearchBar.Text = "";
        }

        private void GunaSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void GunaSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (GunaSearchBar.Text != "")
            {
                qvScrollBar1.ClearContent();

                List<string> matches = SearchMatch(GunaSearchBar.Text);

                for (int i = 0; i < chapters.Count; i++)
                {
                    bool isHave = false;
                    for (int j = 0; j < matches.Count; j++)
                    {
                        if (chapters[i].Name == matches[j])
                        {
                            isHave = true;
                            break;
                        }
                    }

                    if (isHave == true)
                    {
                        TitleButtonPrefab button = new TitleButtonPrefab();
                        button.Location = new Point(3, button.Location.Y);
                        button.SetText(chapters[i].Name);

                        qvScrollBar1.AddControl(button);
                    }
                }

                qvScrollBar1.ReInitContent();
                qvScrollBar1.SetScrollbarParameters();
            }
            else
            {
                qvScrollBar1.ClearContent();
                InitScrollBar();
                qvScrollBar1.SetScrollbarParameters();
            }
        }
    }

    public class Chapter
    {
        public string Name { get; private set; }
        public string[] Tags;

        public string PathToFile { get; private set; }

        public TitleButtonPrefab TitlePanel { get; private set; }

        public Chapter(string name, string[] tags, string pathToFile)
        {
            Name = name;
            Tags = new string[tags.Length];
            Array.Copy(tags, Tags, tags.Length);
            TitlePanel = new TitleButtonPrefab();
            PathToFile = pathToFile;
        }
    }
}
