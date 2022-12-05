using System;
namespace InlämningsuppgiftOOPvendingmachine
{
    //Abstract klass för de olika produktklasserna att ärva från
    public abstract class Product
    {
        //Attribut
        public string name;
        public string price;
        public string productinfo;

        //Konstruktor
        public Product(string name, string price, string productinfo)
        {
            this.name = name;
            this.price = price;
            this.productinfo = productinfo;
        }
    }
}

