﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_a_zmienna
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.DodajOcene(3);
            karta.DodajOcene(6);

            Karta karta2 = karta;
            karta2.DodajOcene(4);

        }
    }
}
