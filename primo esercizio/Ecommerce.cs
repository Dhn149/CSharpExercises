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
        


   }  
    
