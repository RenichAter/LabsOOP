using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Rational
    {
        public int Numerator;
        public int Denominator;
        public Rational(int Numerator, int Denominator) {
            try
            {
                string test_zero = $"{Numerator / Denominator}";
            }
            catch
            {
                Console.WriteLine("Division by zero");
            }
            finally
            {
                this.Numerator = Numerator;
                this.Denominator = Denominator;
                reduce(ref this.Numerator, ref this.Denominator);
            }
        }
        override public string ToString()
        {
            if (Denominator % Numerator == 0 && Denominator != 0 && Numerator != 1)
            {
                return $"{Numerator / Denominator}";
            }
            return $"{Numerator}/{Denominator}";
        }
        public void reduce(ref int _Numerator, ref int _Denominator)
        {
            Numerator = _Numerator;
            Denominator = _Denominator;
            int GeneralDenominator = GDS(Numerator < 0 ? -(Numerator) : Numerator, Denominator);
            if (GeneralDenominator == Numerator) { }
            Numerator /= GeneralDenominator;
            Denominator /= GeneralDenominator;
            _Numerator = Numerator;
            _Denominator = Denominator;
        }
        public int GDS(int num, int den)
        {

            if (num == 0)
            {
                return den;
            }
            else
            {
                while (den != 0)
                {
                    if (num > den)
                    {
                        num -= den;
                    }
                    else
                    {
                        den -= num;
                    }
                }

                return num;
            }
        }
        public static Rational operator + (Rational Rational1, Rational Rational2)
        {
            int new_Numerator = Rational1.Numerator * Rational2.Denominator + Rational2.Numerator * Rational1.Denominator;
            int new_Denominator = Rational1.Denominator * Rational2.Denominator;
            Rational new_rational = new Rational(new_Numerator, new_Denominator);
            return new_rational;
        }
        public static Rational operator -(Rational Rational1, Rational Rational2)
        {
            int new_Numerator = Rational1.Numerator * Rational2.Denominator - Rational2.Numerator * Rational1.Denominator;
            int new_Denominator = Rational1.Denominator * Rational2.Denominator;
            Rational new_rational = new Rational(new_Numerator, new_Denominator);
            return new_rational;
        }
        public static Rational operator *(Rational Rational1, Rational Rational2)
        {
            int new_Numerator = Rational1.Numerator * Rational2.Numerator;
            int new_Denominator = Rational1.Denominator * Rational2.Denominator;
            Rational new_rational = new Rational(new_Numerator, new_Denominator);
            return new_rational;
        }
        public static Rational operator /(Rational Rational1, Rational Rational2)
        {
            int new_Numerator = Rational1.Numerator * Rational2.Denominator;
            int new_Denominator = Rational1.Denominator * Rational2.Numerator;
            Rational new_rational = new Rational(new_Numerator, new_Denominator);
            return new_rational;
        }
        public static Rational operator -(Rational Rational)
        {
            int new_Numerator = Rational.Numerator * (-1);
            Rational new_rational = new Rational(new_Numerator, Rational.Denominator);
            return new_rational;
        }
        public static bool operator ==(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator == Rational2.Numerator && Rational1.Denominator == Rational2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator != Rational2.Numerator || Rational1.Denominator != Rational2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator/Rational1.Denominator < Rational2.Numerator/ Rational2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator / Rational1.Denominator < Rational2.Numerator / Rational2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator / Rational1.Denominator < Rational2.Numerator / Rational2.Denominator || Rational1.Numerator == Rational2.Numerator && Rational1.Denominator == Rational2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Rational Rational1, Rational Rational2)
        {
            if (Rational1.Numerator / Rational1.Denominator < Rational2.Numerator / Rational2.Denominator || Rational1.Numerator == Rational2.Numerator && Rational1.Denominator == Rational2.Denominator)
            {
                return true;
            }
            return false;
        }

    }
}
