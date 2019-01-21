using System;
using System.Collections.Generic;
using System.Linq;


namespace KartaOcenFilmow
{
    public class Karta : KartaPodstawowa
    {
        public Karta()
        {
            oceny = new List<float>();
            Licznik++;
        }
        // stan (zmienne - pola)
        protected List<float> oceny;

        public static float minOcena = 0;
        public static float maxOcena = 10;
        public static long Licznik = 0;



        // zachowania (metody)
        /// <summary>
        /// Dodanie nowej onecy do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>

        public override void DodajOcene(float ocena)
        {
            if (ocena >= 0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }
            
        }

        /// <summary>
        /// Obliczanie sredniej z listy ocen
        /// </summary>
        /// <returns>Wzraca srednia ocene</returns>

        public float ObliczSrednia()
        {
            //float suma = 0;
            //float srednia = 0;

            //foreach (var item in oceny)
            //{
            //    suma += item;
            //}

            //srednia = suma / oceny.Count;

            //return srednia;

            return oceny.Average();

        }
        /// <summary>
        /// Dostajemy najmniejsza ocene
        /// </summary>
        /// <returns>Najmniejsza ocena</returns>
        public float NajnizszaOcena()
        {
            //float min = float.MaxValue;

            //foreach (var item in oceny)
            //{
            //    if(min > item)
            //    {
            //        min = item;
            //    }
            //}

            //return min;

            return oceny.Min();
        }

        public override KartaStatystyki ObliczStatystyki()
        {
            Console.WriteLine("Karta::ObliczStatystystyki");
            KartaStatystyki stat = new KartaStatystyki();

            float suma = 0;


            foreach (var item in oceny)
            {
                suma += item;
            }

            stat.SredniaOcena = suma / oceny.Count;

            stat.NajniższaOcena = oceny.Min();
            stat.NajwyzszaOcena = oceny.Max();


            return stat;
        }

        /// <summary>
        /// Dostajemy najwieksza ocene
        /// </summary>
        /// <returns>Najwieksza ocena</returns>
        public float NajwyzszaOcena()
        {
            return oceny.Max();
        }

    }
}
