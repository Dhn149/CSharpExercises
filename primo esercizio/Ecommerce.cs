using System;


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
}



    
        



    
   
    
