using System;
namespace InlämningsuppgiftOOPvendingmachine
{
    public class Toy : Product, iProduct
    {
        //Extra attribut
        public string nr;

        //Initiera lista för toys
        public static List<Toy> listtoys = new List<Toy>();

        //Konstruktor
        public Toy(string nr, string name, string price, string productinfo) : base(name, price, productinfo)
        {
            this.nr = nr;
        }


        public void Description()
        {

        }

        public void Buy()
        {
            Console.WriteLine("För att köpa vald produkt tryck på 'J'.För att avbryta köp tryck på 'N'");
        }
        public void Use()
        {
            Console.WriteLine("Kunden använder sin leksak!");
        }
    }
}

