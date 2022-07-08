using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDemo
{

    //define delegates
    public delegate void RectDelegate(double w, double h);
    internal class Rectangle
    {  
        //multicast delegates = holds reference of more than one method 
        //if class contains multiple method with same signature (same return type and parameter) then we can call it through one delegate
        public void GetArea(double w, double h)
        {
            Console.WriteLine("Area = " + (w * h));
        }

        public void GetPerimeter(double w, double h)
        {
            Console.WriteLine("Perimeter = " + (2*(w + h)));
        }



        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(20.0, 19.0);
            rect.GetPerimeter(20.0, 19.0);

            //instantiation of delegates
            RectDelegate rd = new RectDelegate(rect.GetArea);
            RectDelegate rd1 = new RectDelegate(rect.GetPerimeter);

            RectDelegate rd2 = rect.GetArea;
            RectDelegate rd3 = rect.GetPerimeter;

            //at a time two method calls
            rd3 += rect.GetArea;

           //calling methods
           rd.Invoke(20.0, 19.0);
            rd(20.0, 19.0);
            rd1.Invoke(20.0, 19.0);
            rd1(20.0, 19.0);
            rd2.Invoke(20.0, 19.0);
            rd2(20.0, 19.0);
            rd3.Invoke(20.0, 19.0);
            rd3(20.0, 19.0);

            //rd3 calling 
            Console.WriteLine("\n\n\n\n\n");
            rd3.Invoke(20.0, 19.0);
            rd3(20.0, 19.0);




            Console.ReadLine();
        }





    }
}
