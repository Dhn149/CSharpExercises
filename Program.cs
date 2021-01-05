using System;
using System.Collections.Generic;
using ECommerce;
using ExLinq;
using Mountains;
using System.Linq;



namespace primo_esercizio
{
    class Program
    {
        /*
        static void Main(string [] args)
        { 
            Peaks.FirstColumn(";","Monte Falco, 1658, Parco Foreste Casentinesi ; Monte Falterona, 1654, Parco Foreste Casentinesi; Monte Fumaiolo, 1407, Appennino Tosco Emiliano");
        
        
         }
         */
          static void Main(string[] args)
        {
            /* primo esercizio svolto 
            Console.WriteLine("Please, insert your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name.ToUpper()}");
            */

            /*
            string catchArgs = args[0];
            var args1 = catchArgs.ToUpper();
            System.Console.WriteLine($"This is my argument to upper {args1}");
            */
           Customer Coso= new Customer(1,"Pippo","Franco");
            Coso.login();

            Customer Gino = new Customer(7,"Gino","Estrada");      //Create customer
            Gino.Add();
            Customer Nedo = new Customer(8,"Nedo","Fioravante");
            Nedo.Add();


            DateTime now = DateTime.Now;

            HorderHeader Stock= new HorderHeader(4,now, 13);
            Stock.Create();

            HorderHeader deleteOrder= new HorderHeader(4,now, 13);
            Stock.Cancel();


            HorderHeader ordersList= new HorderHeader(4,now, 13);
            Stock.List();

            Article Redshoes = new Article("Red shoes", 12.44,34);
            Article gloves = new Article("black gloves",22.70, 22);
            Article scarf = new Article("scarf purple and yellow",32.99,56); // Create Article
            Article bluejeans = new Article("blue-jeans", 12.44, 340);
            Article faceMask = new Article("Face mask", 12.44,47);
           
                
            var names = new List<string> { "Glauco", "Annarella", "Gino","Nedo", "Enrico","Asdrubale" };
            Customers myCustumers = new Customers();
           
            foreach (var name in names)
{
            myCustumers.Extraction(name);

}

            Articles addItems = new Articles();
            addItems.AddArticle(gloves);
            addItems.AddArticle(Redshoes);
            addItems.AddArticle(scarf);     //Add article to list
            addItems.AddArticle(bluejeans);
            addItems.AddArticle(faceMask);

            addItems.List();
           addItems.searchArticle("blue-jeans"); 
           // i've found the method to search an article by it descprition






            

    }
}
}
