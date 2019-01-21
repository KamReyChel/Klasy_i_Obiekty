using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaOcenFilmow
{
    class Zwierze
    {
        //Pola(fields) to zmienne zadeklarowane wenatrzklasy,struktury. - polamogą byc tylko do odczytu

        private string _nazwa;
        private string _nazwa2;
        private readonly string _readonly;

        public Zwierze(string nazwa, string nazwa2, string pole)
        {
            _nazwa = nazwa;
            _nazwa2 = nazwa2;
            _readonly = pole;
        }


        //Wlasciwosci (propierties) sa rozszerzeniem dla pol.
        /*uzywaja akcesorow, dzieki czemu pola prywatne sa dostepne z zewnatrzklasy.
         * nie sluza do przechowywania wartosci
         * przy pomocy akcesorow wlasciwosci maja dostep do pol, ktore reprezentuja
         * akcesory zawieraja intrukcje do wykonywania, ktore pozwalaja na odczyt lub zapis wartosci pola
         * deklaracje wlasciwosci moga zawierac akcesory get, set lub oba
         */

        public string Nazwa
        {
            get { return _nazwa; }

            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    _nazwa = value;
                }
            }
        }

        // wlasciwosc tylko do zapisu
        public string Nazwa2
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nazwa2 = value;
                }
            }
        }

        //wlasciwosci tylko do zapisu
        public string Readonly
        {
            get { return _readonly; }


        }

        //wlasciwosc automatyczna (prop + 2*tab)
        public int MyProperty { get; set; }
    }

}
