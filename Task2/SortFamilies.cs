using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate void SortDelegate(int number);
    public class SortFamilies
    {
        public event SortDelegate FamilySortedEvent;
        /// <summary>
        /// Сортировка списка строк по ключу 1: А-Я 2: Я-А
        /// </summary>
        /// <exception cref="FormatException"></exception>
        public void Sort()
        {
            Console.Write("Введите ключ сортировки 1 или 2: ");

            int sortKey = Convert.ToInt32(Console.ReadLine());
            //Отсев не нужных значений
            if (sortKey != 1 && sortKey != 2) throw new FormatException();

            //Вызов события ввода ключа
            KeyEntered(sortKey);
        }

        
        protected virtual void KeyEntered(int sortKey)
        {
            FamilySortedEvent?.Invoke(sortKey);
        }
    }
}
