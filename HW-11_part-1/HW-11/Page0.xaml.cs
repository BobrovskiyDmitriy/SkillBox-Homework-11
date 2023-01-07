using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace HW_11
{
    /// <summary>
    /// Логика взаимодействия для Page0.xaml
    /// </summary>
    public partial class Page0 : Page
    {
        public string[] access_Level_items {get; set;}
        public Page0()
        {
            InitializeComponent();

            access_Level_items = new string[] { "Администратор", "Менеджер", "Консультант" };
            DataContext = this;

            Add_data.IsEnabled = false;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());  
        }

        private void access_Level_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int cb_index = Convert.ToInt32(access_Level.SelectedIndex);
            if (cb_index == 0) // Администратор
            {
                Add_data.IsEnabled = true;
            }

            if (cb_index == 1) //Менеджер
            {
                Add_data.IsEnabled = true;
            }

            if (cb_index == 2)//Консультант
            {
                Add_data.IsEnabled = false;
            }
        }
    }
}
