using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Kalinovskaya
{
    public class Cat
    {
        private string name;//хранение имени кота
        private double weight;//храниение веса кота
        public Cat(string CatName)// Конструктор класса Cat
        {
            name = CatName;
        }
        public Cat(double CatWeight)// Конструктор класса Cat
        {
            weight = CatWeight;
        }
        public void Meow()//метод для вывода сообщения кота
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }
        public bool SetCatName(string newName)//метод проверки ввода имени кота
        {
            foreach (char c in newName)// Проверяем каждый символ в имени
            {
                if (!char.IsLetter(c))// Допускаются только буквы
                {
                    Console.WriteLine("Имя должно содержать только буквы!");
                    return false;
                }
            }
            name = newName;// Сохраняем новое имя
            return true;
        }
        public bool SetCatWeight(double newWeight)//метод проверки ввода веса кота
        {
            if (newWeight <= 0)// Вес должен быть положительным числом
            {
                Console.WriteLine("Вес должен быть положительным числом!");
                return false;
            }
            weight = newWeight;// Сохраняем новый вес
            return true;
        }
        public void PrintInfo()//метод выводит информацию о коте
        {
            Console.WriteLine($"\n--- Информация о коте ---");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Вес: {weight} кг");
        }
    }
}
