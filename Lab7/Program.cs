using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{

    class Program
    {

        static void GetValidName()
        {

            Regex isName = new Regex(@"^[A-Z]{1}[a-z]{29}$");
            string name = Console.ReadLine();

            if (isName.IsMatch(name))
            {

                Console.WriteLine("That's a name.");

            }

            else
            {

                Console.WriteLine("That's not a name.");

            }
           
        }

        static void GetValidEmail()
        {

            Regex isAddress = new Regex(@"^\w{5,}@[A-z]{5,}.[A-z]{2,3}$");
            string address = Console.ReadLine();

            if (isAddress.IsMatch(address))
            {

                Console.WriteLine("That's an e-mail.");

            }

            else
            {

                Console.WriteLine("That's not an e-mail.");

            }

        }

        static void GetValidPhone()
        {

            Regex isPhone = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            string phone = Console.ReadLine();

            if (isPhone.IsMatch(phone))
            {

                Console.WriteLine("That's a phone number.");

            }

            else
            {

                Console.WriteLine("That's not a phone number.");

            }

        }

        static void GetValidDate()
        {

            Regex isDate = new Regex(@"^[0123][0-9]/[01][0-9]/\d{4}$");
            string date = Console.ReadLine();

            if (isDate.IsMatch(date))
            {

                Console.WriteLine("That's a date.");

            }

            else
            {

                Console.WriteLine("That's not a date.");

            }

        }

        static void Main(string[] args)
        {

            GetValidName();
            GetValidEmail();
            GetValidPhone();
            GetValidDate();
            Console.WriteLine("That's all folks!");

        }

    }

}
