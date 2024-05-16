using Ex2;

IDateTimePrinter datetimeEurope = new EuropeanDateTimePrinter();
IDateTimePrinter datetimeAmerica = new AmericanDateTimePrinter();

IDateTimePrinter DecoratedTimeEurope = new DecoratorBack(new DecoratorFront(datetimeEurope, "DMR "), " BNT");
IDateTimePrinter DecoratedTimeAmerica = new DecoratorBack(new DecoratorFront(datetimeAmerica, "DMR "), " BNT");

Console.WriteLine(DecoratedTimeEurope.PrintDateTime());
Console.WriteLine(DecoratedTimeAmerica.PrintDateTime());
