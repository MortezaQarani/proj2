using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            string phone = "";
            Console.ForegroundColor = ConsoleColor.Green;
            int top = Console.CursorTop;
            Console.WriteLine("Please ente your first name:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition("Please ente your first name:".Length, top);
            user.FirstName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            top = Console.CursorTop;
            Console.WriteLine("Please ente your last name:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition("Please ente your last name:".Length + 1, top);
            user.LastName = Console.ReadLine();
            while (true)
            {
                top = Console.CursorTop;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please ente your age:");
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition("Please ente your age:".Length + 1, top);
                    user.Age = int.Parse(Console.ReadLine());
                    if (user.Age < 15 || user.Age > 130)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your registration faild. because, your age is out of range.");
                        Console.ReadKey();
                    }
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid value.");
                }
            }

            while (true)
            {
                top = Console.CursorTop;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please ente your phone number:");
                Console.SetCursorPosition("Please ente your phone number:".Length + 1, top);
                Console.ForegroundColor = ConsoleColor.Yellow;
                phone = Console.ReadLine();
                try
                {
                    if ((phone.Length == 11 && phone.StartsWith("0")) || (phone.Length == 10 && !phone.StartsWith("0")))
                    {
                        user.MobileNumber = long.Parse(phone);
                        phone = user.MobileNumber.ToString();
                        break;
                    }
                    else if (phone.Length == 13 && phone.StartsWith("+98"))
                    {
                        phone = phone.Remove(0, 3);
                        user.MobileNumber = long.Parse(phone);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid phone number.");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid character in phone number.");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nA user was registered with the following information:\nName: {user.FirstName}  {user.LastName}\nPhone number: 0{phone}\nAge: {user.Age} ");
        }
    }
}
