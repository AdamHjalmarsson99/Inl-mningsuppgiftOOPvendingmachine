using System;
namespace InlämningsuppgiftOOPvendingmachine
{
    public class Beverage : Product, iProduct
    {
        //Extra attribut
        public string nr;

        //Initiera lista beverages
        public static List<Beverage> beverages = new List<Beverage>();

        //Konstruktor
        public Beverage(string nr, string name, string price, string productinfo) : base(name, price, productinfo)
        {
            this.nr = nr;
        }

        public void Description()
        {

        }

        public void Buy()
        {
            Console.WriteLine("För att köpa vald produkt tryck på 'J'. För att avbryta köp tryck på 'N'");
        }

        public void Use()
        {
            Console.WriteLine("Kunden dricker den köpta produkten");
        }
    }

}