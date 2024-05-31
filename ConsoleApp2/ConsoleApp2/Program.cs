using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tour tour = new Tour();
            //tour.TourCalc();
            //tour.TourCalc(tour.Namecountry);
            //tour.TourCalc(tour.Namecountry, tour.Kovday);
            //Tour tour1 = new Tour();
            //tour1.TourCalc(tour1.Namecountry);
            //Tour tour2 = new Tour();
            //tour2.TourCalc(tour2.Namecountry, tour2.Kovday);
            Tovar tovar = new Tovar();
            Tovar.InfoTovar();
            tovar.Sum();
            Tovar tovar1 = new Tovar();
            Tovar.InfoTovar();
            tovar1.Sum();
            Console.ReadKey();
        }
    }
}
