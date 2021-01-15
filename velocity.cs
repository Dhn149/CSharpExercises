using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Velocity
{

abstract class AbstractMeter
{

public abstract string Speed(int Distance, int Time);



}
interface IEnglishMeter 
{

    void GetMilesPerHour();
    void GetMilesPerYear();
}




class  ItalianMeter: AbstractMeter

{
   
   public override string Speed(int Distance, int Time)
   {
    var res =0;
    return $"Stai viaggiando a {res} km/h";
   }
   


}


class  EnglishMeter : AbstractMeter, IEnglishMeter
{
 
      public override string Speed(int Distance, int Time)
   {
       var res= 0;
       return $"Your are travelling at {res} mph";
   }
   
   
    public void GetMilesPerHour()
    {
        Console.WriteLine("{res}");

    }   
     public void GetMilesPerYear()
     {
         Console.WriteLine("Stuff");
     }
}
}

