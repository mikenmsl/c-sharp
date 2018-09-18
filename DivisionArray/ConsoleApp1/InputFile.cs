using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InputFile
    {        
        string path;
        public List<double> WorkWithFile()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            List<double> primary = new List<double>();            
            string line = "";
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                try
                {
                    path = Console.ReadLine();
                    line = File.ReadAllText(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Файл не может быть прочтен: ");
                    Console.WriteLine(ex.Message + "\nВведите путь к файлу еще раз");
                    continue;
                }
                inputSuccess = true;
            }            
            var elementsStr = line.Split(new[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
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