using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program83
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите вес посылки (кг): ");
            if (double.TryParse(Console.ReadLine(), out double weight) && weight >= 0)
            {
                string category = weight switch
                {
                    < 2 => "мелкий пакет",
                    >= 2 and < 10.1 => "стандартная",
                    >= 10.1 and <= 31.5 => "тяжеловесная",
                    _ => "крупногабарит"
                };
                Console.WriteLine($"Категория: {category}");
            }
            else
            {
                Console.WriteLine("Ошибка: введите неотрицательное число.");
            }
        }
    }
}