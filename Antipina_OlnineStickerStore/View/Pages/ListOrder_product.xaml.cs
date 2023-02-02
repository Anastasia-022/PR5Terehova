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
    /// Логика взаимодействия для ListOrder_product.xaml
    /// </summary>
    public partial class ListOrder_product : Page
    {
        public ListOrder_product()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            Model.Online_sticker_storeEntities2 online_Sticker_StoreEntities = new Model.Online_sticker_storeEntities2();
            gridDataOrder_product.ItemsSource = online_Sticker_StoreEntities.Order_product.ToList();
        }
    }
}
