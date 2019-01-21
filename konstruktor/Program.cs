using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            osoba osoba1 = new osoba();
            osoba osoba2 = new osoba("Jan", "Kowal");
            osoba osoba3 = new osoba("Jan", "Kowal", "Katowice");
            osoba osoba4 = new osoba("Jan", "Kowal", "Katowice", "Mila 15",18);

            Console.Read();
        }
    }
}
