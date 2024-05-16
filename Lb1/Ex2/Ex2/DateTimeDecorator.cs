using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public abstract class DateTimeDecorator : IDateTimePrinter
    {
        protected IDateTimePrinter dateTimePrinter;

        public DateTimeDecorator(IDateTimePrinter dateTimePrinter)
        {
            this.dateTimePrinter = dateTimePrinter;
        }

        public abstract string PrintDateTime();
    }
}
