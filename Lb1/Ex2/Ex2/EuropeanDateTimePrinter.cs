using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo time_eu = new CultureInfo("pl-PL");
            return DateTime.Now.ToString(time_eu);
        }
    }
}
