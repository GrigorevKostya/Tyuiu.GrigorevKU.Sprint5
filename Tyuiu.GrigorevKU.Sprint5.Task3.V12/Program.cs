using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GrigorevKU.Sprint5.Task3.V12.Lib;

namespace Tyuiu.GrigorevKU.Sprint5.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Григорьев К.Ю. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл.                         *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #12                                                                  *");
            Console.WriteLine("* Выполнил  Григорьев К.Ю. | ИИПб-23-2                                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить         *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх  *");
            Console.WriteLine("* знаков после запятой.                                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
