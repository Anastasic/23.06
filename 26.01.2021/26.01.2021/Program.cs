using System;
using System.Collections.Generic;
namespace mmmm
{
    class Film
    {
        public string Name { get; set; }
        public int God { get; set; }

        public Film(string name, int god)
        {
            Name = name;
            God = god;
        }
        public virtual void Metod() //объявление виртуального метода
        {
            Console.WriteLine("Фильм\nНазвание: " + Name + "\n" + "Год выпуска " + God + "\n");
        }
    }
    class Fantastik : Film
    {
        public string Rezisor { get; set; }

        public Fantastik(string name, int god, string rezisor)
     : base(name, god)
        {
            Rezisor = rezisor;
        }
        public override void Metod() // переопределение метода
        {
            Console.WriteLine("Фильм.Фантастика\nНазвание: " + Name + "\n" + "Год выпуска " + God + "\n" + "Режиссер: " + Rezisor + "\n");
        }
    }
    class Drama : Film
    {
        public string Akter { get; set; }

        public Drama(string name, int god, string akter)
     : base(name, god)
        {
            Akter = akter;
        }
        public override void Metod() // переопределение метода
        {
            Console.WriteLine("Фильм.Драма\nНазвание: " + Name + "\n" + "Год выпуска " + God + "\n" + "Главная мужская роль: " + Akter + "\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Film> films = new List<Film>();
            films.Add(new Film("Хатико ", 2009));
            films.Add(new Fantastik("Бегущий в лабиринте ", 2014, " Уэс Болл "));
            films.Add(new Drama("Титаник ", 1998, " Леонардо Ди Каприо "));

            foreach (Film p in films)
                p.Metod();

            Console.ReadKey();
        }
    }
}
