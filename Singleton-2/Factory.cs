using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2
{
    internal class Factory
    {
        interface ICreditCard
        {
            public string CardName();
            public double CreditAmount();
            public double AnnualCharge();
        }

        class GoldCard : ICreditCard
        {
            public string CardName()
            {
                return "This is Gold Card";
            }
            public double CreditAmount()
            {
                return 5000000.00;
            }
            public double AnnualCharge()
            {
                return 500.00;
            }
        }

        class TitaniumCard : ICreditCard
        {
            public string CardName()
            {
                return "This is Titanium card";
            }
            public double CreditAmount()
            {
                return 6000000.00;
            }
            public double AnnualCharge()
            {
                return 600.00;
            }
        }

        class PlatinumCard : ICreditCard
        {
            public string CardName()
            {
                return "Plantinum card";
            }
            public double CreditAmount()
            {
                return 700000000.00;
            }
            public double AnnualCharge()
            {
                return 700.00;
            }
        }

        public static void Main(string[] args)
        {
            string cardType = "gold";
            ICreditCard creditCard = null;
            if(cardType  == "gold")
            {
                creditCard = new GoldCard();
            }
            else if(cardType == "titanium")
            {
                creditCard = new TitaniumCard();    
            }
            else
            {
                creditCard = new PlatinumCard();
            }
        }
    }
}
    

