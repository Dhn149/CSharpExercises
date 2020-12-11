using System;
using System.Collections.Generic;
using ECommerce;



namespace primo_esercizio
{
    class Program
    {
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

            DateTime now = DateTime.Now;

            HorderHeader Stock= new HorderHeader(4,now, 13);
            Stock.Create();

            HorderHeader deleteOrder= new HorderHeader(4,now, 13);
            Stock.Cancel();


            HorderHeader ordersList= new HorderHeader(4,now, 13);
            Stock.List();

            Article article = new Article(5,"Face mask", 12.44);
            article.CRUD();

            Article newMyArticle = new Article(5,"Face mask", 12.44);
            newMyArticle.List();

            Article newArticle = new Article(5,"Face mask", 12.44);
            newArticle.Retrieve();
                    
                    Article myArticle = new Article(5,"Face mask", 12.44);
                
                    myArticle.Destroy();



        var names = new List<string> { "Glauco", "Annarella", "Gino","Nedo", "Enrico","Asdrubale" };
            Customers myCustumers = new Customers();
           
            foreach (var name in names)
{
            myCustumers.Extraction(name);

}

            Cart cart = new Cart(3, 82, 765);

            cart.ToBuy();

            Cart myCart = new Cart(3,82,765);
            myCart.ToEmpty();

            Cart myNewCart = new Cart(3,82,765);
            myNewCart.List();


        Admin admin = new Admin("Giovan Battista");
        admin.AdminLogin();


        Admin newAdmin = new Admin("Giovan Battista");
        newAdmin.OrderManagement();

        Admin newAdm = new Admin("Giovan Battista");
        newAdm.ArticlesManagement();



          Admin newAdmi = new Admin("Giovan Battista");
        newAdmi.CustomersManagement();
        




       
        }
    
    }
}
