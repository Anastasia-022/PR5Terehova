using System.Linq;
using System.Windows;
using HashPasswords;


namespace Antipina_OlnineStickerStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static bool Test(string TbLogin)
        {
            bool result = false;

            if (TbLogin == "")
            {
                result = false;
            }
            else 
            {
                result = true;            
            }
            return result;
            }
        

        private string strLoginUsers;
        private string strPasswordUsers;        

        private void btn_Authorization_Click(object sender, RoutedEventArgs e)
        {
            Model.Online_sticker_storeEntities2 db = new Model.Online_sticker_storeEntities2();
            HashPasswords.HashPassw hashPassw = new HashPasswords.HashPassw();
            strPasswordUsers = HashPassw.GetHashPassword(passwordBoxPassword.Password);
            strLoginUsers = txtBoxLogin.Text;
            
            if (!string.IsNullOrEmpty(strLoginUsers) && !string.IsNullOrEmpty(strPasswordUsers))
            {
                var findUserAccount = db.Users.Where(x => x.Login == strLoginUsers && x.Password == strPasswordUsers).FirstOrDefault();
                if (findUserAccount != null)
                {
                    View.Windows.MenuSystem menuSystem = new View.Windows.MenuSystem(findUserAccount);
                    menuSystem.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверно введён логин или пароль");
                }
            }
        }
    }
}