using FitnessApp.BL.Controller;
using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.CMD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Добро пожаловать в приложение Fitness!" +
                "\nВведите имя пользователя:");
            var name = Console.ReadLine();

            Console.Write("Введите пол:");
            var gender = Console.ReadLine();

            Console.Write("Введите дату рождения:");
            var birthDay = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите вес :");
            var wieght = double.Parse(Console.ReadLine());

            Console.Write("Введите рост :");
            var hieght = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDay, wieght, hieght);
            userController.Save();
        }
    }
}
