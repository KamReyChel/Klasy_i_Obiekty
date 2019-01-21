using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace KartaOcenFilmow
{
    class Program
    {


        //static void UstawNazwe(out Karta karta)
        //{
        //    karta = new Karta();
        //    karta.Nazwa = "Karta Kamila";
        //}

        //static void ZwiekszNumer(out int numer)
        //{
        //    numer=45;
        //}


        static void Main(string[] args)
        {
            Karta karta = new Karta();

            #region program

            //for (;;)
            //{
            //    Console.WriteLine("Podaj ocene z zakresu 1 - 10");

            //    bool wynik = float.TryParse(Console.ReadLine(), out float ocena);

            //    if (wynik)
            //    {
            //        if (ocena == 11)
            //            break;

            //        if (ocena > 0 && ocena <= 10)
            //            karta.DodajOcene(ocena);
            //        else
            //            Console.WriteLine("Liczba z poza zakresu");
            //    }
            //    else
            //    {
            //        Console.WriteLine("To nie jest liczba");
            //    }


            //}

            //float srednia = karta.ObliczSrednia();
            //float min = karta.NajnizszaOcena();
            //float max = karta.NajwyzszaOcena();

            //Console.WriteLine("Srednia ocena wynosi: " + srednia);
            //Console.WriteLine("Minimalna ocena wynosi: " + min);
            //Console.WriteLine("Maksymalna ocena wynosi: " + max);

            #endregion

            #region hermetyzacja

            //karta.DodajOcene(4);
            //karta.DodajOcene(8);
            //karta.DodajOcene(2);
            //karta.DodajOcene(4.5f);
            //karta.DodajOcene(3);

            //KartaStatystyki statystyki = karta.ObliczStatystyki();

            //Console.WriteLine("Srednia ocena: " + statystyki.SredniaOcena);
            //Console.WriteLine("Minimalna ocena: " + statystyki.NajniższaOcena);
            //Console.WriteLine("Maksymalna ocena: " + statystyki.NajwyzszaOcena);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Karta karta1 = new Karta();

            //karta1.DodajOcene(3);
            //karta1.DodajOcene(2);
            //karta1.DodajOcene(2.6f);
            //karta1.DodajOcene(9.5f);
            //karta1.DodajOcene(1);

            //KartaStatystyki statystyki1 = karta1.ObliczStatystyki();

            //Console.WriteLine("Srednia ocena: " + statystyki1.SredniaOcena);
            //Console.WriteLine("Minimalna ocena: " + statystyki1.NajniższaOcena);
            //Console.WriteLine("Maksymalna ocena: " + statystyki1.NajwyzszaOcena);


            //Karta karta2 = new Karta();
            //Karta karta3 = new Karta();
            //Karta karta4 = new Karta();

            //Console.WriteLine("OCENA MAX: " + Karta.maxOcena);
            //Console.WriteLine("Liczba kart: " + Karta.Licznik);

            #endregion

            #region metody
            //Karta karta1 = new Karta();
            //Karta karta2 = karta1;

            //UstawNazwe(out karta2);

            //int x1 = 6;
            //ZwiekszNumer(out x1);

            ////karta1.Nazwa = "Karta Marcina";

            //Console.WriteLine(karta2.Nazwa);
            //Console.WriteLine(x1);

            #endregion

            #region kod
            //Ksiazka ksiazka1;

            //ksiazka1.Tytul = "Programowanie";
            //ksiazka1.Autor = "Betlejewski";
            //ksiazka1.Id = 24;

            //Console.WriteLine("tytul ksiazki: {0}", ksiazka1.Tytul);

            //int zmn = 14;

            //SpeechSynthesizer synt = new SpeechSynthesizer();
            //synt.Speak("Czesc Kamil");
            #endregion

            #region metody2
            //Karta karta1 = new Karta();
            //karta1.DodajOcene(1);
            //karta1.DodajOcene(5);
            //karta1.DodajOcene(6);
            //karta1.DodajOcene(9);

            ////KartaStatystyki stat = karta1.ObliczStatystyki();
            ////WypiszWynik("Srednia", stat.SredniaOcena);
            ////WypiszWynik("Najwyzsza", (int) stat.NajwyzszaOcena);
            ////WypiszWynik("Najnizsza", (long) stat.NajniższaOcena);

            ////WypiszWynik("Test", 55,1,1);
            ////WypiszWynik("Params", 3,4,5,6);

            //karta1.Nazwa = "Karta Marcina";
            //karta1.Nazwa = null;
            //Console.WriteLine(karta1.Nazwa);
            #endregion

            #region delegaty
            //Wiadomosc wiadomosc = new Wiadomosc();
            //Wypisz wypisz = new Wypisz(wiadomosc.WypiszWiadomosc);

            //wypisz += new Wypisz(metoda);

            //wypisz("Witaj Kamil!");
            #endregion

            #region delegaty2
            //Karta karta = new Karta();
            //karta.ZmianaNazwy += KiedyZmianaNazwy;
            //karta.ZmianaNazwy += new ZmianaNazwyDelegat(KiedyZmianaNazwy2);

            ////karta.ZmianaNazwy = null;

            //karta.Nazwa = "Karta Kamila";
            //karta.Nazwa = "Karta Adama";
            //Console.WriteLine(karta.Nazwa);

            #endregion

            #region interfejsy_i_wyjatki

            //IKartaPodstawowa kartaOcen = UtworzKarte();
            //kartaOcen.DodajOcene(3);
            //kartaOcen.DodajOcene(8);
            //kartaOcen.DodajOcene(7);
            //kartaOcen.DodajOcene(2);

            //KartaStatystyki statystyki = kartaOcen.ObliczStatystyki();

            //Console.WriteLine("Prosze podaj nazwe karty");

            //try
            //{
            //    karta.Nazwa = Console.ReadLine();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("");
            //}
            //catch(NullReferenceException)
            //{
            //    Console.WriteLine("Cos poszlo nie tak");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Blad ogolny");
            //}

            //Console.WriteLine("Srednia: " + statystyki.SredniaOcena);
            //Console.WriteLine("Najnizsza: " + statystyki.NajniższaOcena);
            //Console.WriteLine("Najwyzsza: " + statystyki.NajwyzszaOcena);
            #endregion

            StreamWriter plik = new StreamWriter("mojepliki.txt");

            try
            {
                plik.WriteLine("Piszemy do pliku");
            }
            finally
            {
                plik.Close();
            }

            using (StreamWriter plik2 = new StreamWriter("mojepliki2.txt", true))
            {
                plik2.WriteLine("Piszemy do pliku po raz drugi");
                
            }

            Console.Read();
        }

        private static IKartaPodstawowa UtworzKarte()
        {
            return new LepszaKarta();
        }

        private static void KiedyZmianaNazwy2(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine("**********************************");
        }

        private static void KiedyZmianaNazwy(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.IstniejacaNazwa} na {args.NowaNazwa}");
        }

        private static void Metoda(string wiadomosc)
        {
            Console.WriteLine(wiadomosc + "!!!!!!");
        }

        static void WypiszWynik(string opis, float wynik)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        static void WypiszWynik(string opis, int wynik)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        static void WypiszWynik(string opis, long wynik)
        {
            Console.WriteLine(opis + ": " + wynik);
        }
        static void WypiszWynik(string opis, long wynik, int test, int test2)
        {
            Console.WriteLine(opis + ": " + wynik);
        }

        static void WypiszWynik(string opis, params float[] wynik)
        {
            string text = "";

            foreach (var item in wynik)
            {
                text = text + item + " ";
            }

            Console.WriteLine(text);
        }
    }

    
}
