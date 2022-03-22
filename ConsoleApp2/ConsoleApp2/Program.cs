using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad Soyad: ");
            string Fulname = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            User user = new User(Fulname,Email);
            Console.Write("Password: ");
            user.Password = Console.ReadLine();
            user.FulName = Fulname;
            user.Email = Email;

            Console.WriteLine(user.ShowInfo());
        }
    }
}
