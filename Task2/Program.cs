namespace Task2
{
    internal class Program
    {
        static List<string> families = new List<string>() { "Михайлов", "Петров", "Иванов", "Сидоров", "Орлов" };
        static void Main(string[] args)
        {
           bool b = true;
            while (b)
            {
                SortFamilies sf = new SortFamilies();
                sf.FamilySortedEvent += SortFamily;
                try
                {
                    sf.Sort(); b = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Нужно вводить только 1 или 2");
                }
            }
        }
        public static void SortFamily(int number)
        {
            families.Sort(); //Сортировка А-Я
            if (number == 2) families.Reverse(); //Сортировка Я-А
            Console.WriteLine();
            Console.WriteLine("Отсортированный список фамилий");
            Console.WriteLine();
            foreach (string family in families)
            {
                Console.WriteLine(family);
            }
        }
    }
}
