using System;
using System.Collections.Generic;
using System.Linq;


namespace Klasa_a_zmienna
{
    public class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }
        // stan (zmienne - pola)
        List<float> oceny;

        

        // zachowania (metody)
        /// <summary>
        /// Dodanie nowej onecy do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>

        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
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
