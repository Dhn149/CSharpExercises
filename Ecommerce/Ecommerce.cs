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

        private int Id;
        private string Description;
        private double Price;
        private int Stock;
        public int IvaRate;

        public Article(int Id, string Description, double Price) {



            Id =  5;
            Description = "facemask";      
            Price =  12.44;

            }


    public void CRUD() {

        Console.WriteLine($"These are your articles{this.Id} {this.Description} {this.Price}");

    }
    public void List(){
    
    Console.WriteLine($" This is your's list {this.Id} {this.Description}{this.Price}");
    
    }
    public void Retrieve(){
    
    Console.WriteLine($" Do tou want to retrieve this{this.Id} {this.Description}{this.Price}");

    }
    public void Destroy(){
    
    Console.WriteLine($" Do you want to destroy this {this.Id} {this.Description}{this.Price}");
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
    

     





        



    
   
    
