using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InputRand
    {
        public List<double> RandomFill(int size)
        {
            Random rnd = new Random();                        
            Console.WriteLine("Размер масcива: " + size + "\nЗаполненный массив:\n");
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(-1999999, 1999999);
                Console.WriteLine(array[i].ToString() + " ");
            }
            List<double> returned = array.ToList();
            return (returned);
        }
    }
}
