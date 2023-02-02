using System;
using HashPasswords;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model.Online_sticker_storeEntities1 db = new Model.Online_sticker_storeEntities1();
            var myUser = new Users.Model.Users();
            Console.WriteLine("Создание новой учётной записи");
            
            Console.WriteLine("Введите фамилию: ");
            myUser.Surname = Console.ReadLine();
            
            Console.WriteLine("Введите имя: ");
            myUser.Name = Console.ReadLine();

            Console.WriteLine("Введите отчество: ");
            myUser.Middle_name = Console.ReadLine();

            Console.WriteLine("Введите логин: ");
            myUser.Login = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string hashPassword = HashPassw.GetHashPassword(Console.ReadLine());
            myUser.Password = hashPassword;
            Console.WriteLine("Хэшированный пароль " + hashPassword);
            Console.ReadLine();
            db.Users.Add(myUser);
            db.SaveChanges();
        }
    }
}
