using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11
{
    [Serializable]
    public class Customers
    {
        public List<Customer> CustomersList { get; set; } = new List<Customer>();
    }

    [Serializable]
    public class Customer : IPerson
    {
        //private string passport;


        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Last_name { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string First_name { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string Middle_name { get; set; }

        /// <summary>
        /// Телефон клиента
        /// </summary>
        public string Phone_numb { get; set; }

        /// <summary>
        /// Серия и номер паспорта клиента
        /// </summary>
        public string Passport { get; set; }
        //public string Passport {
        //    get {
        //        if (passport != null) {
        //            return "*********";
        //        } else {
        //            return null;
        //        }
        //    }
        //    set { 
        //        passport= value;
        //    }
        //}

        public Customer() { }

        public Customer(
            string last_name,
            string first_name,
            string middle_name,
            string phone_numb,
            string passport)
        {
            Last_name = last_name;
            First_name = first_name;
            Middle_name = middle_name;
            Phone_numb = phone_numb;
            Passport = passport;
        }

    }
}
