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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Antipina_OlnineStickerStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для listUsers.xaml
    /// </summary>
    public partial class listUsers : Page
    {
        public listUsers()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Model.Online_sticker_storeEntities2 online_Sticker_StoreEntities = new Model.Online_sticker_storeEntities2();
            gridDataUsers.ItemsSource = online_Sticker_StoreEntities.Users.ToList();
        }
    }
}