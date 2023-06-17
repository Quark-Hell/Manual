using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManualC_
{
    public partial class Form1 : Form
    {
        Chapter[] chapters = { 
            new Chapter("Методы", new string[] { "именованный", "блок", "метод", "вызов","повторно" }),
            new Chapter("Операторы", new string[] { "умножить", "делить", "сумма", "разность","произведение" }),
            new Chapter("Массивы", new string[] { "однотипный", "набор", "данных", "индексы","многомерные", "двумерные" }),
            new Chapter("Библиотечные классы", new string[] { "system", "half", "double", "boolean","int", "char" })
        };

        private void InitTitleList()
        {
            ManualList.Items.Clear();
            for (int i = 0; i < chapters.Length; i++)
            {
                ManualList.Items.Add(chapters[i].Name);
            }
        }

        private List<string> SearchMatch(string searchWord)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < chapters.Length; i++)
            {
                //if name similar searchWord
                if (chapters[i].Name.IndexOf(searchWord,0,StringComparison.OrdinalIgnoreCase) != -1)
                {
                    output.Add(chapters[i].Name);
                    continue;
                }
                for (int j = 0; j < chapters.Length; j++)
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

        public Form1()
        {
            InitializeComponent();
            InitTitleList();
        }

        private void ManualList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            InitTitleList();
            List<string> matches = SearchMatch(Search.Text);

            for (int i = 0; i < ManualList.Items.Count; i++)
            {
                bool isHave = false;
                for (int j = 0; j < matches.Count; j++)
                {
                    if (ManualList.Items[i].ToString() == matches[j])
                    {
                        isHave = true;
                        break;
                    }
                }

                if (isHave == false)
                {
                    ManualList.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            Search.ForeColor = Color.Black;
            Search.Text = "";
            InitTitleList();
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            Search.ForeColor = Color.Gray;
            Search.Text = "Поиск";
            InitTitleList();
        }
    }

    public class Chapter
    {
        public string Name { get; private set; }
        public string[] Tags;

        public Chapter(string name, string[] tags = default)
        {
            Name = name;
            Tags = new string[tags.Length];
            Array.Copy(tags, Tags, tags.Length);
        }
    }

    public class Search
    {

    }
}
