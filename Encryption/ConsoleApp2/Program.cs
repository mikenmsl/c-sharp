
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Cases
    {
        CONSOLE = 1, FILE, RAND, EXIT
    }
    public enum Code
    {
        ENCODE_ATB = 1, DECODE_ATB, ENCODE_CEA, DECODE_CEA
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Алгоритмы: Атбаш и Caesar\n" +
            "Вариант 3.\nВыполнил студент 465 группы\nНикита Васильевич Зотов\n");
            bool inputSuccess = true;
            Random rnd = new Random();
            End ex = new End();
            while (inputSuccess)
            {
                Console.WriteLine("\nДля ввода данных с клавиатуры нажмите 1\nДля ввода данных из файла нажмите 2\nДля рандомного заполнения нажмите 3\nДля выхода нажмите 4");
                List<char> primary = new List<char>();
                int size = 0;
                int value = 0;
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
                string answerAtbash = "";
                string answerCaesar = "";
                value = 0;
                if (primary.Count > 0)
                {
                    var inceptive = String.Join("", primary.ToArray());
                    IChiper atbash = new Atbash();
                    IChiper caesar = new Caesar();
                    var code = (Code)ex.EnumAns();
                                    
                    switch (code)
                    {
                        case Code.ENCODE_ATB:
                            value = 1;
                            answerAtbash = atbash.Encode(inceptive);
                            Console.WriteLine("Результат шифрования методом Атбаш: " + answerAtbash);
                            break;
                        case Code.DECODE_ATB:
                            value = 2;
                            answerAtbash = atbash.Decode(inceptive);
                            Console.WriteLine("Результат шифрования методом Атбаш: " + answerAtbash);
                            break;
                        case Code.ENCODE_CEA:
                            value = 3;
                            answerCaesar = caesar.Encode(inceptive);
                            Console.WriteLine("Результат шифрования методом Caesar: " + answerCaesar);
                            break;
                        case Code.DECODE_CEA:
                            value = 4;
                            answerCaesar = caesar.Decode(inceptive);
                            Console.WriteLine("Результат шифрования методом Caesar: " + answerCaesar);
                            break;                        
                    }
                    bool saveChoise = false;
                    Console.WriteLine("Желаете сохранить результаты работы программы?");
                    saveChoise = ex.Ans();
                    bool deleteInfo = false;
                    if (saveChoise)
                    {
                        Console.WriteLine("Введите путь");
                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Файл существует. При сохранении данные будут стёрты. Желаете перезаписать файл?");
                            deleteInfo = ex.Ans();
                            if (deleteInfo)
                            {
                                ex.Saving(primary, answerAtbash, answerCaesar, path, value);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                            ex.Saving(primary, answerAtbash, answerCaesar, path, value);
                    }
                    Console.WriteLine("Желаете сохранить исходные данные программы?");
                    saveChoise = ex.Ans();
                    deleteInfo = false;
                    if (saveChoise)
                    {
                        Console.WriteLine("Введите путь");
                        string path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Файл существует. При сохранении данные будут стёрты. Желаете перезаписать файл?");
                            deleteInfo = ex.Ans();
                            if (deleteInfo)
                            {
                                ex.Saving(primary, answerAtbash, answerCaesar, path, 0);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                            ex.Saving(primary, answerAtbash, answerCaesar, path, 0);
                    }
                }
                Console.WriteLine("Желаете протестировать программу еще раз?");
                inputSuccess = ex.Ans();
                continue;
            }
        }
    }
}
