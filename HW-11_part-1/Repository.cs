using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace HW_11_part_1
{
    public class Repository
    {
        public List<Customer> _customer { get; set; }
        
        public Repository()
        {
           _customer = new List<Customer>();
           _customer = GetCustomerFromTxt();
        }

        public List<Customer> GetCustomerFromTxt()
        {
            string curFile = Path.Combine("Customers.txt");
            Console.WriteLine(File.Exists(curFile) ? "\n Запись добавлена" : "\n Customers.txt создан. Запись добавлена");
            using (StreamWriter sw = new StreamWriter("Customers.txt", true, Encoding.Unicode)) ;
            System.Threading.Thread.Sleep(1000);


            var customers = new List<Customer>();
            string[] customersTxt = File.ReadAllLines("Customers.txt");


            foreach (string customerTxtString in customersTxt)
            {
                var customer = GetCustomerFromTxtString(customerTxtString);
                customers.Add(customer);
            }
            return customers;
        }

        public Customer GetCustomerFromTxtString(string customerTxtString)
        {
            string[] props = customerTxtString.Split('*');

            string last_name   = props[0];
            string first_name  = props[1];
            string middle_name = props[2];
            string phone_numb  = props[3];
            string passport    = props[4];

            var customer = new Customer(
                last_name, 
                first_name, 
                middle_name, 
                phone_numb, 
                passport
                );

            return customer;
        }


        public void Create(Customer customer)
        {
            _customer.Add(customer);
        }

        public void SaveChanges()
        {
            using (StreamWriter sw = new StreamWriter("Customers.txt", false))
            {
                foreach (var cutomer in _customer)
                {
                    sw.WriteLine(
                        cutomer.Last_name + "*" +
                        cutomer.First_name + "*" +
                        cutomer.Middle_name + "*" +
                        cutomer.Phone_numb + "*" +
                        cutomer.Passport
                        );
                }
            }
        }
    }
}