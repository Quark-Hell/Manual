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
        FavoriteInfo FavoritePagesInfo;

        int CurrentPage = -1;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            GunaTitleList.MouseWheel += new MouseEventHandler(TitleListScrollbar.Panel_MouseWheel);
            GunaInfoLabelPanel.MouseWheel += new MouseEventHandler(InfoLabelScrollbar.Panel_MouseWheel);

            InitScrollBar();
            TitleListScrollbar.SetScrollbarParameters();

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer, true);

            SetDoubleBuffered(GunaTitleList);

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

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        #region App Logic
        private void InitLogic()
        {
            string pagesPath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Pages\\";

            chapters.Add(new Chapter("Методы", new string[] { "именованный", "блок", "метод", "вызов", "повторно" }, pagesPath + "Array.html"));
            chapters.Add(new Chapter("Операторы", new string[] { "умножить", "делить", "сумма", "разность", "произведение" }, pagesPath + "Array.html"));
            chapters.Add(new Chapter("Массивы", new string[] { "однотипный", "набор", "данных", "индексы", "многомерные", "двумерные" }, pagesPath + "Array.html"));
            chapters.Add(new Chapter("Классы", new string[] { "system", "half", "double", "boolean", "int", "char" }, pagesPath + "Array.html"));

            Dictionary<string, bool> fp = new Dictionary<string, bool>();
            for (int i = 0; i < chapters.Count; i++)
            {
                fp.Add(chapters[i].Name, false);
            }
            FavoritePagesInfo = new FavoriteInfo(fp);

            InitScrollBar();
            TitleListScrollbar.SetScrollbarParameters();

            InfoLabelScrollbar.AddControl(GunaInfoLabel);
            InfoLabelScrollbar.SetScrollbarParameters();
        }

        private void InitScrollBar()
        {
            for (int i = 0; i < chapters.Count; i++)
            {
                TitleButtonPrefab button = new TitleButtonPrefab(GunaInfoLabel, chapters[i].PathToFile);
                button.Location = new Point(3, button.Location.Y);
                button.SetText(chapters[i].Name);

                button.Label = GunaInfoLabel;
                button.Scrollbar = InfoLabelScrollbar;

                TitleListScrollbar.AddControl(button);
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

        private void GunaNextButton_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            if (CurrentPage == chapters.Count)
            {
                GunaNextButton.Visible = false;
            }
        }

        private void GunaPreviousButton_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            if (CurrentPage == 0)
            {
                GunaPreviousButton.Visible = false;
            }
        }

        private void GunaHideButton_Click(object sender, EventArgs e)
        {
            GunaInfoLabelPanel.Visible = false;
        }

        private void GunaLogoutButton_Click(object sender, EventArgs e)
        {
            GunaInfoLabelPanel.Visible = false;
            GunaLoginMenu.Visible = true;
            CurrentPage = -1;
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

        class FavoriteInfo
        {
            /// <summary>
            /// string - name<br />
            /// bool - isFavorite<br />
            /// </summary>
            public Dictionary<string, bool> FavoritePages { get; private set; } = new Dictionary<string, bool>();

            public FavoriteInfo(Dictionary<string, bool> favoritePages)
            {
                FavoritePages = favoritePages;
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
                        TitleButtonPrefab button = new TitleButtonPrefab(GunaInfoLabel, chapters[i].PathToFile);
                        button.Location = new Point(3, button.Location.Y);
                        button.SetText(chapters[i].Name);

                        TitleListScrollbar.AddControl(button);
                    }
                }

                TitleListScrollbar.ReInitContent();
                TitleListScrollbar.SetScrollbarParameters();
            }
            else
            {
                TitleListScrollbar.ClearContent();
                InitScrollBar();
                TitleListScrollbar.SetScrollbarParameters();
            }
        }

        private void GunaFavoriteButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage != -1)
            {
                chapters[CurrentPage].SetFavorite(!chapters[CurrentPage].IsFavorite);
            }
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
            GunaPreviousButton.Visible = true;
            GunaNextButton.Visible = true;
            GunaLogoutButton.Visible = true;

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

            //TODO: Launch the app by new user

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
            string fileName = Scrambler.EncodePasswordToBase64(JsonSerializer.Serialize(loginInfo.Login)) + ".txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Data\\" + fileName;

            if (!File.Exists(path))
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                GunaErrorLabel.Text = "Такого аккаунта не существует <img src=\"" + file + "\" width=\"20\" height=\"20\">";
                GunaErrorLabel.Visible = true;
                GunaColorTransition.AutoTransition = true;
                return;
            }

            using (StreamReader reader = new StreamReader(path))
            {
                if (scramb != reader.ReadLine())
                {
                    string file = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\Images\\Warning.png";
                    GunaErrorLabel.Text = "Такого аккаунта не существует <img src=\"" + file + "\" width=\"20\" height=\"20\">";
                    GunaErrorLabel.Visible = true;
                    GunaColorTransition.AutoTransition = true;
                    return;
                }
            }

            OpenApp();
        }
        #endregion

        /*======================================================================================*/
        /*======================================================================================*/
        /*======================================================================================*/

        #region Guna EnterBar Logic
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
}
