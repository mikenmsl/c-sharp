using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class KeybordSize
    {
        public int SizeKeyboard()
        {
            bool inputSuccess = false;
            int n = 0;
            while (!inputSuccess)
            {
                Console.Write("Введите размер массива: ");
                string Keyboard = Console.ReadLine();
                int size;
                if (!int.TryParse(Keyboard, out size)) //Пытаемся преобразовать считанную строчку в число
                {
                    Console.WriteLine("Размер массива должен быть числом.");
                    continue;
                }
                if (size < 0)
                { 
                    Console.WriteLine("Размер массива должен быть неотрицательным.");
                    continue;
                }
                n = size;
                inputSuccess = true;
            }
            return (n);
            }
        }
    }
