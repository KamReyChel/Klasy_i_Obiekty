using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaOcenFilmow
{
    public class LepszaKarta : Karta
    {
        public override KartaStatystyki ObliczStatystyki()
        {
            Console.WriteLine("LepszaKarta::ObliczStatystystyki");
            float najnizsza = float.MaxValue;

            foreach (var ocen in oceny)
            {
                najnizsza = Math.Min(ocen, najnizsza);
            }

            oceny.Remove(najnizsza);
            return base.ObliczStatystyki();
        }
    }
}
