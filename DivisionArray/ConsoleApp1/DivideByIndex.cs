using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivideByIndex
    {
        public double [] Even(List<double> lOne) //Четные индексы
        {
            double [] array = lOne.ToArray();
            int k = 0;
            double [] returned = new double[array.Length / 2 + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 1)
                {
                    returned[k] = array[i];
                    k++;
                }
            }
            return (returned);
        }
        public double [] Odd(List<double> lOne) //Нечетные индексы
        {
            double [] array = lOne.ToArray();            
            double [] returned = new double[array.Length / 2];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    returned[k] = array[i];
                    k++;
                }
            }
            return (returned); 
        }       
    }
}
