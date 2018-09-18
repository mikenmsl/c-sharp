using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InputConsole
    {
        public List<double> ReadList()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Введите элементы массива в строчку. Числа с плавающей точкой вводить в формате 1.1. Закончить ввод сиволом Enter");
            List<double> primary = new List<double>();
            string keyboard = Console.ReadLine();
            var elementsStr = keyboard.Split(new[] { ' ', ',', '\n', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in elementsStr)
            {
                double listElement;

                if (!double.TryParse(element, out listElement))
                {
                    continue;
                }
                primary.Add(listElement);
            }
            Console.WriteLine("Считано элементов:" + primary.Count);          
            return primary;
        }
    }
}

