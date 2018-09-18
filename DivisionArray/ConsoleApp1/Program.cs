
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Cases
    {
        CONSOLE = 1, FILE, RAND, EXIT
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Задан одномерный массив размером N. Сформировать 2 массива размером N/2,\n" +
                    "включая в первый элементы исходного массива с четными индексами, а во второй — с нечетными.\nВычислить суммы элементов каждого из массивов.\n");
            bool inputSuccess = false;
            Random rnd = new Random();
            End ex = new End();
            while (!inputSuccess)
            {
                Console.WriteLine("\nДля ввода данных с клавиатуры нажмите 1\nДля ввода данных из файла нажмите 2\nДля рандомного заполнения нажмите 3\nДля выхода нажмите 4");
                List<double> primary = new List<double>();
                int size = 0;
                Menu menu = new Menu();
                var choise = (Cases)menu.ChoiseCase();                                
                switch (choise)
                {
                    case Cases.CONSOLE:                    
                        InputConsole fillList = new InputConsole();
                        primary = fillList.ReadList(); //Заполнили список элементов
                        break;
                    case Cases.FILE:
                        Console.WriteLine("\nУкажите путь к данным в формате (D:\\AZINO777\\...\nВведите числа в строчку, десятичные дроби введите в формате 1.1 Ввод закончите символом Enter");
                        InputFile file = new InputFile();
                        primary = file.WorkWithFile();
                        break;
                    case Cases.RAND:                        
                        size = rnd.Next(1, 20);
                        InputRand fill = new InputRand();
                        primary = fill.RandomFill(size);
                        break;
                    case Cases.EXIT:
                        System.Environment.Exit(0);
                        break;
                }                
                if (primary.Count > 0)
                {
                    double[] first = new double[size / 2 + 1];
                    double[] second = new double[size / 2];
                    DivideByIndex firstList = new DivideByIndex();
                    first = firstList.Even(primary);
                    second = firstList.Odd(primary);
                    CountSum answer = new CountSum();
                    Console.WriteLine("Сумма элементов с четными индексами: " + answer.ReturnSum(first));
                    Console.WriteLine("Сумма элементов с нечетными индексами: " + answer.ReturnSum(second));                    
                    bool saveChoise = false;
                    Console.WriteLine("Желаете сохранить результаты работы программы?");
                    saveChoise = ex.Ans(saveChoise);
                    bool deleteInfo = false;
                    if (saveChoise)
                    {
                        Console.WriteLine("Введите путь");
                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Файл существует. При сохранении данные будут стёрты. Желаете перезаписать файл?");
                            deleteInfo = ex.Ans(deleteInfo);
                            if (deleteInfo)
                            {
                                ex.Saving(primary, answer.ReturnSum(first), answer.ReturnSum(second), path);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                } 
                Console.WriteLine("Желаете протестировать программу еще раз?");
                inputSuccess = ex.Ans(inputSuccess);
                continue;
            }
        }
    }
}
