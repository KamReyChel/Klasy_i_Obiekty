using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaOcenFilmow
{
    public abstract class KartaPodstawowa :IKartaPodstawowa
    {
        public abstract void DodajOcene(float ocena);

        public abstract KartaStatystyki ObliczStatystyki();

        protected string _nazwa;

        //Wlasciwosc
        public string Nazwa
        {
            get
            {
                return _nazwa.ToUpper();
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nazwa karty nie moze byc pusta");
                }
                if (_nazwa != value && ZmianaNazwy != null)
                {
                    ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                    args.IstniejacaNazwa = _nazwa;
                    args.NowaNazwa = value;

                    ZmianaNazwy(this, args);
                }

                _nazwa = value;
                
            }
        }
        //zdarzenie

        public event ZmianaNazwyDelegat ZmianaNazwy;
    }
}
