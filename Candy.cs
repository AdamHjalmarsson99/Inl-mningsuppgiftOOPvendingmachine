using System;
namespace InlämningsuppgiftOOPvendingmachine
{
    public class Candy : Product, iProduct
    {
        //Extra attribut
        public string nr;

        //Initiera lista för candies
        public static List<Candy> listcandies = new List<Candy>();

        //Konstruktor
        public Candy(string nr, string name, string price, string productinfo) : base(name, price, productinfo)
        {
            this.nr = nr;
        }

        public void Buy()
        {
            Console.WriteLine("För att köpa vald produkt tryck på 'J'. För att avbryta köp tryck på 'N'");
        }

        public void Description()
        {
            Console.WriteLine("");
        }

        public void Use()
        {
            Console.WriteLine("Kunden äter nu godiset");
        }


    }


}

