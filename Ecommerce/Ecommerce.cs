using System;
using System.Collections.Generic;


namespace  ECommerce

{
    class  Customer

    {
        public int Id;
        public string Name;
        public string Surname;
        protected string Address;
        protected int Cap;
        protected string City;
        protected string Email;
        protected string Password;
      



        public Customer(int id, string name, string surname) {

        Id = id;
        Name = name;
        Surname = surname;
    }

        public void login() {
            Console.WriteLine($"Welcome to my site, this is {this.Id} {this.Name} {this.Surname}");
        }
        
        public void Add(){
        
        Console.WriteLine($"Add the{this.Id}{Name}{Surname}");
    }

        
    }  

    class HorderHeader {

        private int Id;
        private DateTime Data;
        private int NumeroOrdine;
        public int IdUtente;

        public HorderHeader(int id, DateTime data, int numeroOrdine)
        {

        Id = id;
        this.Data = data;
        NumeroOrdine= numeroOrdine;
        }

        public void Create(){
            Console.WriteLine($"Those are your orders {this.Id}{this.Data}{this.NumeroOrdine}");


        }
        
        public void Cancel(){

            Console.WriteLine($" Cancel the operation {this.Id} {this.Data}{this.NumeroOrdine}");
        }
        public void List() {

             Console.WriteLine($" This is your order's list {this.Id} {this.Data}{this.NumeroOrdine}");
        }
        
        }
        
    class Article{

        private int _Id;
        public string _Description;
        public double _Price;
        public int _Stock;
        public int IvaRate;

        public Article(string description, double price,int stock) {

            this._Stock = stock;
            this._Description = description;
            this._Price = price;
        }

    public void CRUD() {

       

    }
    public void List(){
    
   
    
    }
    public void Retrieve(){
    
   

    }
    public void Destroy(){
    
    }
    
    public void Add(){

                
    }
        



    }
    class Customers {


        private string Names;
        private int Id;

        private int IdUtente;

    public void Extraction(string names){
// estrarre  nomi da metodo
        Console.WriteLine($"the names are {names}");

    }
    
    }
    class OrderDetail {
        private int Id;
        public int IdOrder;
        public int IdArticle;
        private double Price;
        private int Stock;


        public OrderDetail (int id, int idArticle, double price) {

                Id = id;
                IdArticle = idArticle;
                Price = price;

        }

        public void List() {
            Console.WriteLine($"This is the list of the Order detail {this.Id}, {this.IdArticle}, {this.Price}");
        }
    }


    class Articles {


        private string Article;
        private int Id;
        private double Price;
        private int Stock;
        public int IvaRate;
        public List<Article> myList;

       public Articles() {

                myList = new List<Article>();
    }

            public void AddArticle(Article genericArticle){

                myList.Add(genericArticle);
}
    public void List(){

        foreach(var item in myList)
        {
                Console.WriteLine($"{item._Description}");
        }

    
}
   public void searchArticle(string searchTerm)
   {
       foreach(var item in myList)
       {
            if(searchTerm == item._Description)
            {
                Console.WriteLine($"{item._Price}");
            }
       }
   }
}
    

    class Cart{
        private int Id;
        private int IdArticle;
        private int IdCustomer;

        private int Stock;

        public Cart (int id, int idArticle, int idCustomer) {
        
        Id = id;
        IdArticle = idArticle;
        IdCustomer = idCustomer;
        
        }
            
            public void ToBuy(){

                Console.WriteLine($"{this.Id} Do you want to buy this {this.IdArticle}? Please Confirm {this.IdCustomer}");
            }
        
            public void ToEmpty(){

                Console.WriteLine($"{this.Id} Do you wanto to empty the cart and canceled {this.IdArticle}? Please Confirm {this.IdCustomer}");
            }

        public void List(){
    
    Console.WriteLine($" This is your's list {this.Id} {this.IdArticle}{this.IdCustomer}");
    }

     public void Add(){

                Console.WriteLine($"{this.Id} You {this.IdCustomer} just added this article {this.IdArticle} in the cart");
            }




    }
    class Admin {
        private string Administrator;

        public Admin(string administrator) {
            Administrator = administrator;
        }

        public void AdminLogin() {
            Console.WriteLine($"Welcome to the site, this is {this.Administrator}");
        }

            public void OrderManagement() {

                Console.WriteLine($"Those orders are controlled by {this.Administrator}");

            }

            public void ArticlesManagement() {

                Console.WriteLine($"These articles are managed by {this.Administrator}");
            }

            public void CustomersManagement() {

                 Console.WriteLine($"These Customers are managed by {this.Administrator}");
            }

        
        }
    }
    

     





        



    
   
    
