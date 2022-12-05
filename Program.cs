
using InlämningsuppgiftOOPvendingmachine;

internal class Program
    {

        static void Main(string[] args)
        {
            //De skapade produkterna i de olika listorna




            Beverage.beverages.Add(new Beverage("1.", "Nocco", "27 Kr", "Energidryck med smak av Päron"));
            Beverage.beverages.Add(new Beverage("2.", "Vitamin Well", "25 Kr", "Vitaminvatten med elektrolyter"));
            Beverage.beverages.Add(new Beverage("3.", "Pepsi Max", "22 Kr", "Den perfekta läsken för att släcka din törst"));




            Candy.listcandies.Add(new Candy("1.", "Mars", "20 kr", "Krämig chokladbar"));
            Candy.listcandies.Add(new Candy("2.", "Daim", "17 Kr", "Krispig chokladkaka som definitivt kommer fastna i dina tänder"));
            Candy.listcandies.Add(new Candy("3.", "Skittles", "22 Kr", "Små goda fruktgodisar"));



            Toy.listtoys.Add(new Toy("1.", "Studsboll", "15 Kr", "En boll som studsar välidgt bra"));
            Toy.listtoys.Add(new Toy("2.", "Schack", "35 Kr", "Ett strategiskt brädpsel med olika pjäser"));
            Toy.listtoys.Add(new Toy("3.", "Boomerang", "25 Kr", "En leksak man kastar i luften som sen kommer tillbaka till dig"));




            //Funktionen med kod för varuatomaten
            Menu();



        }



        //Skapar funktion en funktion för kundens val av produkter. 
        private static void Menu()
        {



            //"Grafiska" menyn
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Skriv in ett nummer för att välja kategori");
            Console.WriteLine("1. Godis");
            Console.WriteLine("2. Toy");
            Console.WriteLine("3. Beaverage");
            Console.WriteLine("4. Avsluta köp");
            Console.WriteLine("--------------------------------------------");
            //Skapar variabel för användarens inputval av huvudmenyn
            string input = Console.ReadLine();




            //if- sats för kundens val i huvudmenyn
            if (input == "1")
            {
                //Gör console.clear för att det ska bli snyggare i terminal, samt skapar en foreach loop av de objekt i Candylistan så kuden får se produkterna, pris och information om godisarna.
                Console.Clear();
                foreach (Candy candies in Candy.listcandies)
                {



                    Console.WriteLine("{0} {1} {2} {3}", candies.nr, candies.name, candies.price, candies.productinfo);
                }
                //Grafiska tillägg för kundens nya meny av godis
                Console.WriteLine("4. Gå tillbaka till menyn");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Skriv in nummer för att välja godis:");



                //Initierar ny variabel för användarens inputval av menyn för candies
                Console.Write(":");
                string inputCandy = Console.ReadLine();



                //Rad av if-satser för användarens val av menyn candies, där den fjärde if-satsen är "avbryt" och tar dig tillbaka till huvudmenynmenyn
                if (inputCandy == "1")
                {
                    Console.Clear();
                    Candy.listcandies[0].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Candy.listcandies[0].name, Candy.listcandies[0].price);
                        Candy.listcandies[0].Use();




                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();



                    }



                }
                if (inputCandy == "2")
                {
                    Console.Clear();
                    Candy.listcandies[1].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Candy.listcandies[1].name, Candy.listcandies[1].price);
                        Candy.listcandies[1].Use();



                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }



                }
                if (inputCandy == "3")
                {
                    Console.Clear();
                    Candy.listcandies[2].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en påse {0} för {1}.", Candy.listcandies[2].name, Candy.listcandies[2].price);
                        Candy.listcandies[2].Use();

                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();



                    }



                }
                if (inputCandy == "4")
                {
                    Console.Clear();
                    Menu();



                }



            }
            //fortsättning av första if-satsen för huvudmenyn
            else if (input == "2")
            {
                //Gör console.clear för att det ska bli snyggare i terminal, samt skapar en foreach loop av de objekt i toyslistan så kuden får se produkterna, pris och information om toys alternativen.
                Console.Clear();
                foreach (Toy toys in Toy.listtoys)
                {
                    Console.WriteLine("{0} {1} {2} {3}", toys.nr, toys.name, toys.price, toys.productinfo);
                }
                //Grafiska tillägg för kundens nya meny av toys
                Console.WriteLine("4. Gå tillbaka till menyn");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Skriv in nummer för att välja leksak");



                //Initierar ny variabel för användarens inputval av menyn för toys
                Console.Write(":");
                string inputToy = Console.ReadLine();



                //Rad av if-satser för användarens val av menyn toys, där den fjärde if-satsen är "avbryt" och tar dig tillbaka till huvudmenynmeny
                if (inputToy == "1")
                {
                    Console.Clear();
                    Toy.listtoys[0].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Toy.listtoys[0].name, Toy.listtoys[0].price);
                        Toy.listtoys[0].Use();
                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }
                }
                if (inputToy == "2")
                {
                    Console.Clear();
                    Toy.listtoys[1].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Toy.listtoys[1].name, Toy.listtoys[1].price);
                        Toy.listtoys[1].Use();
                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }




                }
                if (inputToy == "3")
                {
                    Console.Clear();
                    Toy.listtoys[2].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Toy.listtoys[2].name, Toy.listtoys[2].price);
                        Toy.listtoys[2].Use();
                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }



                }
                if (inputToy == "4")
                {
                    Console.Clear();
                    Menu();




                }



            }
            //fortsättning av första if-satsen för huvudmenyn
            else if (input == "3")
            {
                //Gör console.clear för att det ska bli snyggare i terminal, samt skapar en foreach loop av de objekt i beverageslistan så kuden får se produkterna, pris och information om beverages alternativen.
                Console.Clear();
                foreach (Beverage beverage in Beverage.beverages)
                {
                    Console.WriteLine("{0} {1} {2} {3}", beverage.nr, beverage.name, beverage.price, beverage.productinfo);
                }
                //Grafiska tillägg för kundens nya meny av beverages
                Console.WriteLine("4. Gå tillbaka till menyn");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Skriv in nummer för att välja dryck");



                //Initierar ny variabel för användarens inputval av menyn för beverages
                Console.Write(":");
                string inputBev = Console.ReadLine();



                //Rad av if-satser för användarens val av menyn beverages, där den fjärde if-satsen är "avbryt" och tar dig tillbaka till huvudmenyn
                if (inputBev == "1")
                {
                    Console.Clear();
                    Beverage.beverages[0].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Beverage.beverages[0].name, Beverage.beverages[0].price);
                        Beverage.beverages[0].Use();
                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }



                }
                if (inputBev == "2")
                {
                    Console.Clear();
                    Beverage.beverages[1].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Beverage.beverages[1].name, Beverage.beverages[1].price);
                        Beverage.beverages[1].Use();
                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }



                }
                if (inputBev == "3")
                {
                    Console.Clear();
                    Beverage.beverages[2].Buy();
                    Console.Write("");



                    //Initiering av variabel för kunds val av att köpa vald produkt eller avbryta
                    string yesorno = Console.ReadLine().ToUpper();



                    //if-sats för att fråga kund om den vill köpa den valda produkten eller om den vill backa till menyn.
                    if (yesorno == "J")
                    {
                        Console.Clear();
                        Console.WriteLine("Du har köpt en {0} för {1}.", Beverage.beverages[2].name, Beverage.beverages[2].price);
                        Beverage.beverages[2].Use();




                    }
                    else if (yesorno == "N")
                    {
                        Console.Clear();
                        Menu();
                    }

                }
                if (inputBev == "4")
                {
                    Console.Clear();
                    Menu();



                }



            }
            //Tillhörande första if-satsen av huvudmenyn och är det alternativet som avbryter sessionen.
            else if (input == "4")
            {
                Console.Clear();
                Console.WriteLine("Köp avbrutet, välkommen åter!");
            }
        }
    }
