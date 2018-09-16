using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InputFile
    {
        string path;
        public List<char> WorkWithFile()
        {
            List<char> primary = new List<char>();
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
            foreach (char element in line)
            {                
                primary.Add(element);
            }
            Console.WriteLine("Считано элементов:" + primary.Count);
            return primary;
        }
    }
}