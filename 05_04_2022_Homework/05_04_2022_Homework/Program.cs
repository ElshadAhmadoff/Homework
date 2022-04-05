using System;

namespace _05_04_2022_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usd = new USD(400);
            AZN azn = new AZN(340);
            EURO eur = new EURO(100);
            Console.WriteLine(eur.Amount > usd.Amount);
        }
    }
    public class AZN
    {
        public double Amount;
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount / 1.7);
        }
        public static implicit operator EURO(AZN azn)
        {
            return new EURO(azn.Amount / 1.87);
        }
        public static bool operator >(USD usd, AZN azn)
        {
            return usd.Amount > azn.Amount * 1.7;
        }
        public static bool operator <(USD usd, AZN azn)
        {
            return usd.Amount < azn.Amount * 1.7;
        }
        public static bool operator >(EURO eur, AZN azn)
        {
            return eur.Amount > azn.Amount * 1.87;
        }
        public static bool operator <(EURO eur, AZN azn)
        {
            return eur.Amount < azn.Amount * 1.87;
        }
    }
    public class EURO
    {
        public double Amount;
        public EURO(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(EURO eur)
        {
            return new AZN(eur.Amount * 1.87);
        }
        public static implicit operator USD(EURO eur)
        {
            return new USD(eur.Amount * 1.1);
        }
        public static bool operator >(EURO eur, USD usd)
        {
            return eur.Amount > usd.Amount * 1.1;
        }
        public static bool operator <(EURO eur, USD usd)
        {
            return eur.Amount < usd.Amount * 1.1;
        }
    }
    public class USD
    {
        public double Amount;
        public USD(double Amount)
        {
            this.Amount = Amount;
        }
        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount * 1.7);
        }
        public static implicit operator EURO(USD usd)
        {
            return new AZN(usd.Amount / 1.1);
        }
    }
}
