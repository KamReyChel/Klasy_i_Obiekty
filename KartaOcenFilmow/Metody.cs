using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaOcenFilmow
{
    public class Metody
    {
        public void WriteAsByte(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:x2}", b);
            }
        }


    }
}
