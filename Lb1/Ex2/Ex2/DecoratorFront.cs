using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class DecoratorFront : DateTimeDecorator
    {
        private string customString;

        public DecoratorFront(IDateTimePrinter dateTimePrinter, string customString)
            : base(dateTimePrinter)
        {
            this.customString = customString;
        }

        public override string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(customString);
            sb.Append(dateTimePrinter.PrintDateTime());
            return sb.ToString();
        }
    }
}
