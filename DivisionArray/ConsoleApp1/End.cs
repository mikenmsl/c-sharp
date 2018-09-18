using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class End
    {        
        public void Saving(List<double> primary, double first, double second, string path)
        {
            double[] arr = primary.ToArray();
            string odd = first.ToString();
            string even = second.ToString();
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                StreamWriter sw;
                try
                {                    
                    using (sw = new StreamWriter(path))
                    {
                        sw.WriteLine("Введенные данные: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            sw.WriteLine(" " + arr[i]);
                        }
                        sw.WriteLine("\nCумма элементов с четными индексами: " + odd);
                        sw.WriteLine("\nCумма элементов с нечетными индексами: " + even);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: ");
                    Console.WriteLine(ex.Message + "\nВведите путь к файлу еще раз");
                    path = Console.ReadLine();
                    continue;
                }
                inputSuccess = true;
            }
            Console.WriteLine("Данные сохранены.");
        }
        public bool Ans(bool returned)
        {
            bool inputSuccess = false;            
            while (!inputSuccess)
            {
                Console.WriteLine("Введите число\n1 - Да\n2 - Нет");
                string read = Console.ReadLine();
                int command;
                int.TryParse(read, out command);
                if (command == 1)
                {
                    returned = true;
                    inputSuccess = true;
                }
                else if (command == 2)
                {
                    returned = false;
                    inputSuccess = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
            }
            return (returned);
        }
    }
}
