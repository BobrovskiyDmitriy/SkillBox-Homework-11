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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HW_11
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        public Customer SetCustomer()
        {
            Customer customer = new Customer();

            customer.Last_name = TB_Last_name.Text;
            customer.First_name = TB_First_name.Text;
            customer.Phone_numb = TB_Phone_numb.Text;
            

            if (TB_Middle_name.Text == string.Empty)
            {
                customer.Middle_name = "[не указано]";
            }
            else customer.Middle_name = TB_Middle_name.Text;
            
            if (TB_Passport.Text == string.Empty)
            {
                customer.Passport = "[не указано]";
            }
            else customer.Passport = TB_Passport.Text;

            if(TB_Last_name.Text == string.Empty || TB_First_name.Text == string.Empty || TB_Phone_numb.Text == string.Empty)
            {
                MessageBox.Show("Поля Имя, Фамилия и Номер телефона должны быть заполнены.");
            }

            return customer;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page0());
        }

        private void data_add_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = SetCustomer();
            SerializeXML(customer);

        }

        public void AddcustomerToLV(Customer customer)
        {
            ListViewItem LVI = new ListViewItem();
            LVI.Tag = customer;

        }

        public Customers DeSerializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Customers));

            using (FileStream fs = new FileStream("Customers.xml", FileMode.OpenOrCreate))
            {
                return (Customers)xml.Deserialize(fs);
            }
        }

        private void SerializeXML(Customer customer)
        {
            if(customer.Last_name  == null || customer.Last_name  == string.Empty ||
               customer.First_name == null || customer.First_name == string.Empty ||
               customer.Phone_numb == null || customer.Phone_numb == string.Empty  )
            {
                MessageBox.Show("Заполните необходимые поля. Запись не сохранена!");
                return;
            }

            XmlSerializer xml = new XmlSerializer(typeof(Customer));


            using (FileStream fs = new FileStream("Customers.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, customer);
            }

            MessageBox.Show("Запись добавлена!");
        }
    }
}
