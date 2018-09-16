using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InputRand
    {
        private static Random rnd = new Random();

        public List<char> RandomFill(int size)
        {
            
            Console.WriteLine("Количество элементов в строке: " + size + "\nСтрока для шифрования:\n");
            char[] array = new char[size];            
            for (int i = 0; i < size; i++)
            {
                int num = rnd.Next(0, 235);
                array[i] = (char)('0' + num);  
                Console.WriteLine(array[i].ToString() + " ");
            }
            List<char> returned = array.ToList();
            return (returned);
        }
    }
}
