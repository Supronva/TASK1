using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_task_1
{
   public class LinearFuction
    {
       private double a,b;

       public LinearFuction()
       { 
       }

       public LinearFuction(double a,double b)
   {
           this.a = a;
           this.b = b;

   }

       public double A
       {
           get { return a; }
       }

       public double B
       {
           get { return b; }
       }

       public double Fuction(int x)
       {
           return a*x+b;
       }

     
    }
}
