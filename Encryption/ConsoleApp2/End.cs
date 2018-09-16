using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class End
    {
        public void Saving(List<char> primary, string first, string second, string path, int value)
        {
            char[] arr = primary.ToArray();
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                StreamWriter sw;
                try
                {
                    using (sw = new StreamWriter(path))
                    {
                        if (value == 0)
                            for (int i = 0; i < arr.Length; i++)
                            {
                                sw.WriteLine(" " + arr[i]);
                            }
                        else
                        {
                            if (value == 1 || value == 2)
                                sw.WriteLine("\n" + first);
                            else
                                sw.WriteLine("\n" + second);
                        }
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
        public bool Ans()
        {
            bool returned = false;
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                Console.WriteLine("Выберите дальнейшее действие:\n1 - Да\n2 - Нет");
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
        public int EnumAns()
        {
            int returned = 0;
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                Console.WriteLine("Выберите дальнейшее действие:\n1 - Зашифровать методом Атбаш\n2 - Дешифровать методом Атбаш\n3 - Зашифровать методом Цезаря\n4 - Дешифровать методом Цезаря");
                string read = Console.ReadLine();
                int command;
                int.TryParse(read, out command);
                if (command == 1)
                {
                    returned = 1;
                    inputSuccess = true;
                }
                else if (command == 2)
                {
                    returned = 2;
                    inputSuccess = true;
                }
                else if (command == 3)
                {
                    returned = 3;
                    inputSuccess = true;
                }
                else if (command == 4)
                {
                    returned = 4;
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
