using System;

namespace ConsoleApp2
{
    class Menu
    {
        public int ChoiseCase()
        {
            int n = 0;
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                string choise = Console.ReadLine();
                int selected;
                int.TryParse(choise, out selected);
                if (selected <= 0 || selected > 4)
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    continue;
                }
                else
                {
                    n = selected;
                    inputSuccess = true;
                }
            }
            return (n);
        }
    }
}

