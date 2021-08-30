using System;

namespace FlowControl
{
    class Program
    {
        //If-Else
        static void Main(string[] args)
        {
            int a = 100;
            if (a < 20)
            {
                
                Console.WriteLine("a is less than 20");
            }
            else
            {
                
                Console.WriteLine("a is not less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------");
        
            //Nested-If
        int x = 100;
        int y = 200;
         
        
         if (x == 100) 
            {
          
            if (y == 200) 
                {
               
               Console.WriteLine("Value of x is 100 and y is 200");
            }
            }
           Console.WriteLine("Exact value of a is : {0}", x);
           Console.WriteLine("Exact value of b is : {0}", y);
           Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");
            
            //Else-If ladder
            Console.WriteLine("Enter a number to check grade:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
        }
    }

}
    
