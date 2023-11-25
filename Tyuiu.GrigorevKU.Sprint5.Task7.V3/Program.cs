using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GrigorevKU.Sprint5.Task7.V3.Lib;
namespace Tyuiu.GrigorevKU.Sprint5.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Григорьев К.Ю. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                     *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #3                                                                   *");
            Console.WriteLine("* Выполнил  Григорьев К.Ю. | ИИПб-23-2                                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все русские буквы   *");
            Console.WriteLine("* из файла.Полученный результат сохранить в файл.                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask7V3.txt";
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V3.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
