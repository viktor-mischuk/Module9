using System;

namespace Module9.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5]
            {
                new MyException("Мое исключение"),
                new DivideByZeroException("Деление на ноль"),
                new DirectoryNotFoundException("Папка не найдена"),
                new NullReferenceException("Объект равен null"),
                new IndexOutOfRangeException("Индекс элемента массива находится вне диапазона допустимых значений")
            };

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (MyException e) { Console.WriteLine($"{i} : {e.Message}"); continue; }
                catch (DivideByZeroException e) { Console.WriteLine($"{i} : {e.Message}"); continue; }
                catch (DirectoryNotFoundException e) { Console.WriteLine($"{i} : {e.Message}"); continue; }
                catch (NullReferenceException e) { Console.WriteLine($"{i} : {e.Message}"); continue; }
                catch (IndexOutOfRangeException e) { Console.WriteLine($"{i} : {e.Message}"); continue; }

            }



            Console.ReadKey();
        }
    }
}
