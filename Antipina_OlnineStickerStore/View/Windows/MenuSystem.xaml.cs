using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Antipina_OlnineStickerStore.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuSystem.xaml
    /// </summary>
    public partial class MenuSystem : Window
    {
        private Model.Users _authUsers;

        public MenuSystem(Model.Users authUsers)
        {
            InitializeComponent();
            _authUsers = authUsers;

            switch (_authUsers.Role)
            {
                case "пользователь":
                    btnListUsers.Visibility = Visibility.Collapsed;
                    break;

                case "администратор":
                    break;

            }
        }
        private void btnListStickers_Click(object sender, RoutedEventArgs e)
        {
            Pages.listStickers listStickers  = new Pages.listStickers();
            MainFrame.Navigate(listStickers);
        }
        private void btnListUsers_Click(object sender, RoutedEventArgs e)
        {
            Pages.listUsers listUsers = new Pages.listUsers();
            MainFrame.Navigate(listUsers);
        }

        private void btnListOrder_product_Click(object sender, RoutedEventArgs e)
        {
            Pages.ListOrder_product listOrder_Product = new Pages.ListOrder_product();
            MainFrame.Navigate(listOrder_Product);
        }

        private void btnListOrder_Click(object sender, RoutedEventArgs e)
        {
            Pages.ListOrder listOrder = new Pages.ListOrder();
            MainFrame.Navigate(listOrder);
        }
    }
}
