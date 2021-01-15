using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace UserList
{


class User
{

    private int Id;
    private int _age;
    private string Name;
    private List<User> userList;
  
public User()
{
    this.userList = new List<User>();
    
}

    public User(int id, string name, int age)
    {
    
        this.Id = id;
        this.Name = name;
        this._age = age;
    }

public int age{
    get => _age;
    

    set {
        if(value >= 18)
        {
            _age = value;
            Console.WriteLine("Congratulation, you are hold enough");
        } else
        {
            Console.WriteLine("not yet!");
            
        }

    }

}
    
       
    public void addUser(User users)
    { 
        this.userList = new List<User>();
        userList.Add(users);
        Console.WriteLine($"{Name} is been added in the userList");
    
   }
    public void Find()
    {
            foreach (var user in userList)
            {
                if(user.Name.Contains("C"))
                {
                    Console.WriteLine($"this is the list of  C names. The name you looking for, {user.Name} is in this list");
                }
            }
    }

    
}
}