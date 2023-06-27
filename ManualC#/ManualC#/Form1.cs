using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace ManualC_
{
    public partial class Form1 : Form
    {
        List<Chapter> chapters = new List<Chapter>();

        int CurrentList = -1;

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
            chapters.Add(new Chapter("Классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "\\Array.html"));

            InitScrollBar();
            qvScrollBar1.SetScrollbarParameters();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            SetDoubleBuffered(TitleList);

            GunaErrorLabel.Text = 
                GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");

            //string path = @"D:\Text_Files\my_file.txt";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //
            //}

            base.OnLoad(e);
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

        #region App Logic
        private void InitScrollBar()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                TitleButtonPrefab button = new TitleButtonPrefab(GunaInfoLabel, chapters[i].PathToFile);
                button.Location = new Point(3, button.Location.Y);
                button.SetText(chapters[i].Name);

                qvScrollBar1.AddControl(button);
            }
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
        #endregion

        #region Up Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void GunaUpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GunaCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GunaWindowScaleButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                GunaWindowScaleButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Normal.png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                GunaWindowScaleButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Maximized.png");
            }
        }
        #endregion

        #region Login Menu
        class LoginInfo
        {
            public string Login { get; private set; }
            public string Password { get; private set; }

            public void SetLogin(string login)
            {
                Login = login;
            }
            public void SetPassword(string password)
            {
                Password = password;
            }
        }

        LoginInfo CurrentSesson;

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
                        TitleButtonPrefab button = new TitleButtonPrefab(GunaInfoLabel, chapters[i].PathToFile);
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

        private void GunaFavoriteButton_Click(object sender, EventArgs e)
        {
            if (CurrentList != -1)
            {
                chapters[CurrentList].SetFavorite(!chapters[CurrentList].IsFavorite);
            }
        }

        private void GunaBackToAuthorizationButton_Click(object sender, EventArgs e)
        {
            GunaRegistationMenu.Visible = false;
            GunaAuthorizationMenu.Visible = true;

            GunaCreateLogin.ForeColor = Color.Gray;
            GunaCreateLogin.Text = "Логин";

            GunaCreatePassword.ForeColor = Color.Gray;
            GunaCreatePassword.Text = "Пароль";
        }

        private void GunaAddUserButton_Click(object sender, EventArgs e)
        {
            GunaRegistationMenu.Visible = true;
            GunaAuthorizationMenu.Visible = false;

            GunaLogin.ForeColor = Color.Gray;
            GunaPassword.Text = "Логин";

            GunaPassword.ForeColor = Color.Gray;
            GunaPassword.Text = "Пароль";
        }
        #endregion

        private void GunaCreateAccountButton_Click(object sender, EventArgs e)
        {
            GunaErrorLabel.Visible = false;

            bool validate = true;

            if (GunaCreateLogin.Text == "" || GunaCreateLogin.Text == "Логин")
            {
                GunaErrorLabel.Text = "Укажите Логин и Пароль <img src=\"warning.png\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Text =
                        GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");
                GunaErrorLabel.Visible = true;

                GunaColorTransition.AutoTransition = true;
                validate = false;
            }

            if (GunaCreatePassword.Text == "" || GunaCreateLogin.Text == "Пароль")
            {
                GunaErrorLabel.Text = "Укажите Логин и Пароль <img src=\"warning.png\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Text =
                        GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");
                GunaErrorLabel.Visible = true;

                GunaColorTransition.AutoTransition = true;
                validate = false;
            }

            if (!validate) { return; }

            LoginInfo loginInfo = new LoginInfo();
            loginInfo.SetLogin(GunaCreateLogin.Text);
            loginInfo.SetPassword(GunaCreateLogin.Text);

            string json = JsonSerializer.Serialize(loginInfo);
            string scramb = Scrambler.EncodePasswordToBase64(json);
            string fileName = Scrambler.EncodePasswordToBase64(JsonSerializer.Serialize(loginInfo.Login)) + ".txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName;

            if (File.Exists(path)) {
                GunaErrorLabel.Text = "Такой аккаунт уже существует <img src=\"warning.png\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Text =
                        GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");
                GunaErrorLabel.Visible = true;
                GunaColorTransition.AutoTransition = true;
                return; }

            
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(scramb);
            }
        }

        #region Guna EnterBar Logic
        private void GunaLogin_Enter(object sender, EventArgs e)
        {
            GunaLogin.ForeColor = Color.Black;
            GunaLogin.Text = "";
        }

        private void GunaLogin_Leave(object sender, EventArgs e)
        {
            if (GunaLogin.Text == "")
            {
                GunaLogin.ForeColor = Color.Gray;
                GunaLogin.Text = "Логин";
            }
        }

        private void GunaPassword_Enter(object sender, EventArgs e)
        {
            GunaPassword.ForeColor = Color.Black;
            GunaPassword.Text = "";
            GunaPassword.PasswordChar = '*';
        }

        private void GunaPassword_Leave(object sender, EventArgs e)
        {
            if (GunaPassword.Text == "")
            {
                GunaPassword.ForeColor = Color.Gray;
                GunaPassword.Text = "Пароль";
                GunaPassword.PasswordChar = default;
            }
        }

        private void GunaLoginButton_Click(object sender, EventArgs e)
        {
            CurrentSesson.SetLogin(GunaLogin.Text);
            CurrentSesson.SetPassword(GunaPassword.Text);
        }

        private void GunaCreateLogin_Enter(object sender, EventArgs e)
        {
            GunaCreateLogin.ForeColor = Color.Black;
            GunaCreateLogin.Text = "";

            GunaColorTransition.AutoTransition = false;
            GunaCreateLogin.BorderColor = Color.Black;
            GunaCreatePassword.BorderColor = Color.Black;

            GunaErrorLabel.Visible = false; 
        }

        private void GunaCreateLogin_Leave(object sender, EventArgs e)
        {
            if (GunaCreateLogin.Text == "")
            {
                GunaCreateLogin.ForeColor = Color.Gray;
                GunaCreateLogin.Text = "Логин";
            }
        }

        private void GunaCreatePassword_Enter(object sender, EventArgs e)
        {
            GunaCreatePassword.ForeColor = Color.Black;
            GunaCreatePassword.Text = "";

            GunaColorTransition.AutoTransition = false;
            GunaCreateLogin.BorderColor = Color.Black;
            GunaCreatePassword.BorderColor = Color.Black;

            GunaErrorLabel.Visible = false;
        }

        private void GunaCreatePassword_Leave(object sender, EventArgs e)
        {
            if (GunaCreatePassword.Text == "")
            {
                GunaCreatePassword.ForeColor = Color.Gray;
                GunaCreatePassword.Text = "Пароль";
            }
        }
        #endregion

        private void GunaColorTransition_ValueChanged(object sender, EventArgs e)
        {
            GunaCreateLogin.BorderColor = GunaColorTransition.Value;
            GunaCreatePassword.BorderColor = GunaColorTransition.Value;
        }
    }

    public class Chapter
    {
        public string Name { get; private set; }
        public string[] Tags;

        public string PathToFile { get; private set; }

        public bool IsFavorite { get; private set; }

        public Chapter(string name, string[] tags, string pathToFile)
        {
            Name = name;
            Tags = new string[tags.Length];
            Array.Copy(tags, Tags, tags.Length);
            PathToFile = pathToFile;
        }

        public void SetFavorite(bool isFavorite)
        {
            IsFavorite = isFavorite;
        }
    }

    public class Scrambler
    {
        //https://www.c-sharpcorner.com/blogs/how-to-encrypt-or-decrypt-password-using-asp-net-with-c-sharp1

        //this function Convert to Encord your Password
        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        //this function Convert to Decord your Password
        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
