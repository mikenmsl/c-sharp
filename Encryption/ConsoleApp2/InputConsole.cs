using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class InputConsole
    {
        public List<char> ReadList()
        {           
            Console.WriteLine("Введите строку символов. Закончитe ввод сиволом Enter");
            List<char> primary = new List<char>();
            string keyboard = Console.ReadLine();
            char[] elements = keyboard.ToArray();
            for (int i = 0; i < elements.Length; i++)
            {                
                primary.Add(elements[i]);
            }
            Console.WriteLine("Считано элементов:" + primary.Count);
            return primary;
        }
    }
}

