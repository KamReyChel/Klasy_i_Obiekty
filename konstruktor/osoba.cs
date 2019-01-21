using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    class osoba
    {
        string imie;
        string nazwisko;
        string miasto;
        string ulica;
        int wiek;

        public osoba()
        {
            imie = "Dafault";
            nazwisko = "Default";
            miasto = "Default";
            ulica = "Default";
            wiek = 10;
            Console.WriteLine("Zadziałał konstruktor domyslny");
        }
        public osoba(string imie, string nazwisko, string miasto, string ulica, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("Zadziałał konstruktor 5 parametrowy");

        }
        public osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            Console.WriteLine("Zadziałał konstruktor 3 parametrowy");
        }

        public osoba(string imie, string nazwisko) : this(imie, nazwisko, "Katowice", "Mila 16", 18)
        {
            Console.WriteLine("Zadziałał konstruktor 2 parametrowy");
        }
    }
}
