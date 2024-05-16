using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class AmericanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            CultureInfo time_usa = new CultureInfo("en-US");
            return DateTime.Now.ToString(time_usa);
        }
    }
}
