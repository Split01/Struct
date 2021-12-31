using System;
using System.Linq;

namespace Zadanie1
{
    struct Marshrut
    {
        private int number;
        private int length;
        private string start;
        private string finish;
        public int Number { get; set; }
        public int Length { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public Marshrut[] InputInfo()
        {
            Marshrut[] marshruts = new Marshrut[10];
            for (int i = 0; i < marshruts.Length; i++)
            {
                Console.WriteLine("Введите номер маршрута");
                marshruts[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину маршрута");
                marshruts[i].Length = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название пункта старта");
                marshruts[i].Start = Console.ReadLine();
                Console.WriteLine("Введите название конечного пункта");
                marshruts[i].Finish = Console.ReadLine();
            }
             void FindMaxLength()
             {
                
                int max = marshruts[0].Length;
                for (int i = 0; i < marshruts.Length; i++)
                {
                    if (marshruts[i].Length> max)
                    {
                        Console.WriteLine(marshruts[i]);
                    }
                }

            }
            //Сортировка
            marshruts.OrderBy(x => x.Number);
            return marshruts;
        }
        
      

        public override string ToString()
        {
            return $"Номер: {Number}\nДлина: {Length}\nНачальный пункт {Start}\nКонечный пункт: {Finish}\n";
        }
    }
    struct Zadanie2
    {
        private string name;
        private int price;
        private int serialNumber;
        private DateTime makeDay;
        private DateTime deathDay;
        public string Name { get; set; }
        public int Price { get; set; }
        public int SerialNumber { get; set; }
        public DateTime MakeDay { get; set; }
        public DateTime DeathDay { get; set; }

        public override string ToString()
        {
            return $"Название: {Name}Цена: {Price} Номер серии: {SerialNumber} Дата изготовления {MakeDay}Годен до: {DeathDay}";
        }
        public string PrintNameAndDeathDay()
        {
            return $"Наименование: {Name}Годен до: {DeathDay}";
        }
    }
    struct Zadanie1
    {
        private string name;
        private string author;
        private string janr;
        private int tiraj;
        public string Name { get; set; }

        public string Author { get; set; }
        public string Janr { get; set; }
        public int Tiraj { get; set; }

        public override string ToString()
        {
            return $"Название: {Name}\nАвтор: {Author}\nЖанр: {Janr}\nТираж: {Tiraj}\n";
        }

        public void Print(Zadanie1 zadanie1)
        {

            if (zadanie1.Tiraj<10000)
            {
                Console.WriteLine(zadanie1);
            }
        }
    }

    static class Program 
    {
        static void Main(string[] args)
        {
            //Задание 1
            Random rand = new Random();
            Console.WriteLine("Введите количество обьектов массива");
            int n = int.Parse(Console.ReadLine());
            Zadanie1[] zadanie1s = new Zadanie1[n];
            for (int i = 0; i < zadanie1s.Length; i++)
            {
                Console.WriteLine("Введите имя");
                zadanie1s[i].Name = Console.ReadLine();
                Console.WriteLine("Введите Автора");
                zadanie1s[i].Author = Console.ReadLine();
                Console.WriteLine("Введите жанр");
                zadanie1s[i].Janr = Console.ReadLine();
                zadanie1s[i].Tiraj = rand.Next(9990, 10000);
            }
            for (int i = 0; i < zadanie1s.Length; i++)
                zadanie1s[i].Print(zadanie1s[i]);
            //Задание 2
            Console.WriteLine("Введите количество обьектов массива");
            int k = int.Parse(Console.ReadLine());
            Zadanie2[] zadanie2s = new Zadanie2[k];
            for (int i=0; i<zadanie2s.Length; i++)
            {
                Console.WriteLine("Введите имя");
                zadanie2s[i].Name = Console.ReadLine();
                Console.WriteLine("Введите цену");
                zadanie2s[i].Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Номер Серии");
                zadanie2s[i].SerialNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Дату изготовления ");
                zadanie2s[i].MakeDay = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите до какого цисла годен");
                zadanie2s[i].DeathDay = DateTime.Parse(Console.ReadLine());

            }
            for (int i = 0; i < zadanie2s.Length; i++)
                zadanie2s[i].PrintNameAndDeathDay();
            //Задание 3
        }
    }
}
