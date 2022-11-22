using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_part_1
{
    public class Customer
    {

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

        
        public Customer(
            string last_name,
            string first_name,
            string middle_name,
            string phone_numb,
            string passport)
        {
            this.Last_name = last_name;
            this.First_name = first_name;
            this.Middle_name = middle_name;
            this.Phone_numb = phone_numb;
            this.Passport = passport;
        }

    }

}