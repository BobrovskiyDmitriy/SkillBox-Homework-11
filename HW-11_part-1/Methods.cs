using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_part_1
{
    class Methods
    {
        public static void MainMenu()
        {
            Console.WriteLine("Укажите свой уровень доступа");

            //Тут будет процесс авторизации
            //условно выбрали ветку, ввели логин-пароль, начали использовать функционал ветки...
            string[] menu = {  "1. Главный парень - без ограничений действий", "2. Консультант - просмотр информации",
                               "3. ***", "4. ****",
                               "5. *****",
                               "6. ******",
                               "7. *******", "-  ВЫХОД"};

            ConsoleKeyInfo q;
            int v = 0;
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == v)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">>> ");
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    else
                    {
                        Console.Write("    ");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.WriteLine(menu[i]);
                }

                q = Console.ReadKey();

                if (q.Key == ConsoleKey.UpArrow && v != 0) v--;
                if (q.Key == ConsoleKey.DownArrow && v != menu.Length - 1) v++;
                

                if (q.Key == ConsoleKey.Enter && v == 0) 
                {
                    Console.WriteLine("\nДоступные действия:");
                    Console.WriteLine("\nДобавление записи        - нажмите 1:");
                    Console.WriteLine("\nПросмотр записей         - нажмите 2:");
                    Console.WriteLine("Возврат в окно авторизации - нажмите 0:");

                    var result = Console.ReadLine();

                    if(result == "1")
                    {
                        Console.WriteLine("\nДобавляем запись:");
                        AddCustomer();
                        continue;
                    }

                    if (result == "2")
                    {
                        Console.WriteLine("\nПросмотр записей:");
                        
                        continue;
                    }

                    if (result == "0")
                    {
                        continue;
                    }
                }

                if (q.Key == ConsoleKey.Enter && v == 1) 
                {
                   
                }

                if (q.Key == ConsoleKey.Enter && v == 2) 
                {

                }

                if (q.Key == ConsoleKey.Enter && v == 3) 
                {
                    
                }

                if (q.Key == ConsoleKey.Enter && v == 4)
                {

                }

                if (q.Key == ConsoleKey.Enter && v == 5) 
                {

                }

                if (q.Key == ConsoleKey.Enter && v == 6)
                {

                }

                if (q.Key == ConsoleKey.Enter && v == 7) //Инструкция 8 // Выход
                {
                    break;
                }

            }

        }

       
        public static void AddCustomer()
        {
            Console.WriteLine("   \nВведите фамилию клиента: ");
            string last_name = Console.ReadLine();

            Console.WriteLine("   \nВведите имя клиента: ");
            string first_name = Console.ReadLine();

            Console.WriteLine("   \nВведите отчество клиента: ");
            string middle_name = Console.ReadLine();

            Console.WriteLine("   \nВведите телефон клиента: ");
            string phone_numb = Console.ReadLine();

            Console.WriteLine("   \nВведите серию и номер паспорта клиента: ");
            string passport = Console.ReadLine();

            var customerRepository = new Repository();

            var customer = new Customer(last_name, first_name, middle_name, phone_numb, passport);
            customerRepository.Create(customer);
            customerRepository.SaveChanges();
            Console.ReadKey();
            
        }

    }
     

}
