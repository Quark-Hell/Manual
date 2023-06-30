using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace ManualC_
{
    public partial class Form1 : Form
    {
        List<Chapter> chapters = new List<Chapter>();

        string OpenLoginFileName = "";
        string OpenSaveFileName = "";
        string CurrentPage = "";

        bool isAuthorized = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            GunaTitleList.MouseWheel += new MouseEventHandler(TitleListScrollbar.Panel_MouseWheel);
            GunaInfoLabelPanel.MouseWheel += new MouseEventHandler(InfoLabelScrollbar.Panel_MouseWheel);

            TitleListScrollbar.ResetScrollbar();

            string pagesPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Pages\\";

            chapters.Add(new Chapter("Методы", new string[] { "именованный", "блок", "метод", "вызов", "повторно" }, pagesPath + "Methods.html"));
            chapters.Add(new Chapter("Операторы", new string[] { "умножить", "делить", "сумма", "разность", "произведение" }, pagesPath + "Array.html"));
            chapters.Add(new Chapter("Массивы", new string[] { "однотипный", "набор", "данных", "индексы", "многомерные", "двумерные" }, pagesPath + "Array.html"));
            chapters.Add(new Chapter("Классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "LibratyClasses.html"));

            InfoLabelScrollbar.AddControl(GunaInfoLabel);

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            SetDoubleBuffered(GunaTitleList);

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

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        #region App Logic
        public void SaveData(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < chapters.Count; i++)
                {
                    string t = chapters[i].ToString();
                    string data = chapters[i].Name.ToString() + ":" + chapters[i].IsFavorite.ToString();

                    writer.WriteLine(data);
                }

                writer.Close();
            }
        }
        public void LoadData(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 0; i < chapters.Count; i++)
                {
                    string str = "";
                    string name;
                    string data;

                    str = reader.ReadLine();

                    int t = str.IndexOf(":");
                    name = str.Substring(0, t);
                    data = str.Substring(t + 1, str.Length - t - 1);

                    for (int j = 0; j < chapters.Count; j++)
                    {
                        if (name == chapters[i].Name)
                        {
                            chapters[i].SetFavorite(Boolean.Parse(data));
                            break;
                        }
                    }
                }
                reader.Close();
            }
        }
        public void ResetChaptersData()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                chapters[i].SetFavorite(false);
            }
        }

        private void InitLogic()
        {
            LoadData(OpenSaveFileName);

            InitTitleList();
            TitleListScrollbar.ResetScrollbar();
            InfoLabelScrollbar.ResetScrollbar();
        }

        public void TitleButton_Click(string buttonName, string pathToFile) 
        {
            using (StreamReader reader = new StreamReader(pathToFile))
            {
                CurrentPage = buttonName;

                for (int i = 0; i < chapters.Count; i++)
                {
                    if (CurrentPage == chapters[i].Name)
                    {
                        if (chapters[i].IsFavorite)
                        {
                            GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Favorite.png");
                        }
                        else
                        {
                            GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\NonFavorite.png");
                        }
                        break;
                    }
                }


                GunaHideButton.Enabled = true;

                string text = reader.ReadToEnd();
                GunaInfoLabel.Text = text;

                InfoLabelScrollbar.ContentContainer.Visible = true;
                InfoLabelScrollbar.ResetScrollbar();
            }
        }

        private void InitTitleList()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                TitleButtonPrefab button = new TitleButtonPrefab();
                button.Location = new Point(3, button.Location.Y);
                button.SetText(chapters[i].Name);

                string str = chapters[i].PathToFile;
                button.Button.Click += (s, e) =>
                {
                    TitleButton_Click(button.Text,str);
                };

                TitleListScrollbar.AddControl(button);
            }

            TitleListScrollbar.ReInitContent();
            TitleListScrollbar.ResetScrollbar();
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
            if (!(GunaSearchBar.Text == "" || GunaSearchBar.Text == "Поиск"))
            {
                TitleListScrollbar.ClearContent();
                InitTitleList();
            }

            GunaSearchBar.ForeColor = Color.Black;
            GunaSearchBar.Text = "";
        }

        private void GunaSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (GunaSearchBar.Text != "")
            {
                TitleListScrollbar.ClearContent();

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

                        string str = chapters[i].PathToFile;
                        button.Button.Click += (se, ev) =>
                        {
                            TitleButton_Click(button.Text, str);
                        };

                        TitleListScrollbar.AddControl(button);
                    }
                }

                TitleListScrollbar.ReInitContent();
                TitleListScrollbar.ResetScrollbar();
            }
            else
            {
                TitleListScrollbar.ClearContent();
                InitTitleList();
                TitleListScrollbar.ResetScrollbar();
            }
        }
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

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
            GunaColorTransition.Dispose();
            Environment.Exit(0);
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

        private void GunaHideButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage != "")
            {
                GunaInfoLabelPanel.Visible = false;

                CurrentPage = "";
                GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\NonFavorite.png");
            }
        }

        private void GunaLogoutButton_Click(object sender, EventArgs e)
        {
            GunaInfoLabelPanel.Visible = false;
            GunaInfoLabel.Text = "";
            InfoLabelScrollbar.ResetScrollbar();

            GunaLoginMenu.Visible = true;

            CurrentPage = "";
            GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\NonFavorite.png");

            TitleListScrollbar.ClearContent();
            TitleListScrollbar.ResetScrollbar();

            GunaSearchBar.Text = "Поиск";
            GunaSearchBar.ForeColor = Color.Gray;
            GunaSearchBar.Enabled = false;

            OpenLoginFileName = "";
            OpenSaveFileName = "";

            isAuthorized = false;
        }

        private void GunaFavoriteButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (CurrentPage == "") { return; }

            for (int i = 0; i < chapters.Count; i++)
            {
                if (CurrentPage == chapters[i].Name)
                {
                    chapters[i].SetFavorite(!chapters[i].IsFavorite);
                    if (chapters[i].IsFavorite)
                    {
                        GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Favorite.png");
                    }
                    else
                    {
                        GunaFavoriteButton.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\NonFavorite.png");
                    }
                    SaveData(OpenSaveFileName);
                    break;
                }
            }
        }
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

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

        private void LoginBarUpdate()
        {
            GunaLogin.ForeColor = Color.Gray;
            GunaLogin.Text = "Логин";

            GunaPassword.ForeColor = Color.Gray;
            GunaPassword.Text = "Пароль";

            GunaColorTransition.AutoTransition = false;
            GunaLogin.BorderColor = Color.FromArgb(213, 218, 223);
            GunaPassword.BorderColor = Color.FromArgb(213, 218, 223);

            GunaPassword.PasswordChar = default;

            GunaErrorLabel.Visible = false;
        }

        private void GunaBackToAuthorizationButton_Click(object sender, EventArgs e)
        {
            GunaRegistationMenu.Visible = false;
            GunaAuthorizationMenu.Visible = true;

            LoginBarUpdate();
        }

        private void GunaAddUserButton_Click(object sender, EventArgs e)
        {
            GunaRegistationMenu.Visible = true;
            GunaAuthorizationMenu.Visible = false;

            LoginBarUpdate();
        }
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        #region Authorization Button Logic
        private void OpenApp()
        {
            GunaLoginMenu.Visible = false;

            GunaFavoriteButton.Visible = true;
            GunaHideButton.Visible = true;
            GunaLogoutButton.Visible = true;
            GunaSearchBar.Enabled = true;

            GunaLogin.Text = "Логин";
            GunaLogin.ForeColor = Color.Gray;

            GunaPassword.Text = "Пароль";
            GunaPassword.ForeColor = Color.Gray;
            GunaPassword.PasswordChar = default;

            isAuthorized = true;

            ResetChaptersData();
            if (File.Exists(OpenSaveFileName))
            {
                LoadData(OpenSaveFileName);
            }
            else
            {
                SaveData(OpenSaveFileName);
            }


            //init app logic like title list
            InitLogic();
        }

        private void GunaCreateAccountButton_Click(object sender, EventArgs e)
        {
            GunaErrorLabel.Visible = false;

            bool validate = true;

            if (GunaLogin.Text == "" || GunaLogin.Text == "Логин")
            {
                GunaErrorLabel.Text = "Укажите Логин и Пароль <img src=\"warning.png\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Text =
                        GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");
                GunaErrorLabel.Visible = true;

                GunaColorTransition.AutoTransition = true;
                validate = false;
            }

            if (GunaPassword.Text == "" || GunaPassword.Text == "Пароль")
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
            loginInfo.SetLogin(GunaLogin.Text);
            loginInfo.SetPassword(GunaPassword.Text);

            string json = JsonSerializer.Serialize(loginInfo);
            string scramb = Scrambler.EncodePasswordToBase64(json);
            string fileName = Scrambler.EncodePasswordToBase64(JsonSerializer.Serialize(loginInfo.Login));
            string path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName + ".txt";

            if (File.Exists(path)) {
                GunaErrorLabel.Text = "Такой аккаунт уже существует <img src=\"warning.png\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Text =
                        GunaErrorLabel.Text.Replace("warning.png", AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png");
                GunaErrorLabel.Visible = true;
                GunaColorTransition.AutoTransition = true;
                return; 
            }

            //Create Login File
            OpenLoginFileName = path;
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(scramb);
                writer.Close();
            }
            //Create Save File
            path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName + "Data" + ".txt";
            OpenSaveFileName = path;

            OpenApp();
            LoginBarUpdate();
        }

        private void GunaLoginButton_Click(object sender, EventArgs e)
        {
            GunaErrorLabel.Visible = false;

            bool validate = true;

            if (GunaLogin.Text == "" || GunaLogin.Text == "Логин")
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                GunaErrorLabel.Text = "Укажите Логин и Пароль <img src=\"" + file + "\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Visible = true;

                GunaColorTransition.AutoTransition = true;
                validate = false;
            }

            if (GunaPassword.Text == "" || GunaPassword.Text == "Пароль")
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                GunaErrorLabel.Text = "Укажите Логин и Пароль <img src=\"" + file + "\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Visible = true;

                GunaColorTransition.AutoTransition = true;
                validate = false;
            }

            if (!validate) { return; }

            LoginInfo loginInfo = new LoginInfo();
            loginInfo.SetLogin(GunaLogin.Text);
            loginInfo.SetPassword(GunaPassword.Text);

            string json = JsonSerializer.Serialize(loginInfo);
            string scramb = Scrambler.EncodePasswordToBase64(json);
            string fileName = Scrambler.EncodePasswordToBase64(JsonSerializer.Serialize(loginInfo.Login));
            string path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName + ".txt";

            if (!File.Exists(path))
            {
                string image = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                GunaErrorLabel.Text = "Такого аккаунта не существует <img src=\"" + image + "\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Visible = true;
                GunaColorTransition.AutoTransition = true;
                return;
            }

            using (StreamReader reader = new StreamReader(path))
            {
                if (scramb != reader.ReadLine())
                {
                    string image = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                    GunaErrorLabel.Text = "Такого аккаунта не существует <img src=\"" + image + "\" width=\"20\" height=\"20\">";
                    GunaErrorLabel.Visible = true;
                    GunaColorTransition.AutoTransition = true;
                    return;
                }

                reader.Close();
            }

            OpenLoginFileName = path;
            OpenSaveFileName = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName + "Data" + ".txt";
            OpenApp();
        }
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        #region Guna Login and Password bar Logic
        private void GunaLogin_Enter(object sender, EventArgs e)
        {
            GunaLogin.ForeColor = Color.Black;
            GunaLogin.Text = "";

            GunaColorTransition.AutoTransition = false;
            GunaLogin.BorderColor = Color.FromArgb(213, 218, 223);
            GunaPassword.BorderColor = Color.FromArgb(213, 218, 223);

            GunaErrorLabel.Visible = false;
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

            GunaColorTransition.AutoTransition = false;
            GunaLogin.BorderColor = Color.FromArgb(213, 218, 223);
            GunaPassword.BorderColor = Color.FromArgb(213, 218, 223);

            GunaErrorLabel.Visible = false;
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
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        private void GunaColorTransition_ValueChanged(object sender, EventArgs e)
        {
            GunaLogin.BorderColor = GunaColorTransition.Value;
            GunaPassword.BorderColor = GunaColorTransition.Value;
        }

        private void guna2GradientPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2GradientPanel1.Refresh();
            Invalidate(guna2GradientPanel1.DisplayRectangle);
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

    public class SaveLoadData
    {

    }
}
