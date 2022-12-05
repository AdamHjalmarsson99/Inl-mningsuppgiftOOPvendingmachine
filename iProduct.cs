using System;
namespace InlämningsuppgiftOOPvendingmachine
{
    //Interface med de metoder produktklasserna ska ärva
    public interface iProduct
    {
        void Description();

        void Buy();

        void Use();
    }
}

