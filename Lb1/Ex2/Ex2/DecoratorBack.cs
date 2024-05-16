using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class DecoratorBack : DateTimeDecorator
    {
        private string customString;

        public DecoratorBack(IDateTimePrinter dateTimePrinter, string customString)
            : base(dateTimePrinter)
        {
            this.customString = customString;
        }

        public override string PrintDateTime()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dateTimePrinter.PrintDateTime());
            sb.Append(customString);
            return sb.ToString();
        }
    }
}
