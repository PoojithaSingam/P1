using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticketPriceChild = 15.0;
            var ticketPriceAdult = 20.0;
            var numChild = 0;
            var numAdult = 0;
            var name = "";
            var ticketCost = 0.0m;
            var exit = "false";
            var choice = 'a';

            Console.WriteLine("Welcome to Wonderland!!");

             while(name == "")
            {
                Console.WriteLine($"Please enter your name: ");
                name = Console.ReadLine();
            }
       Console.WriteLine($"Your name is {name}");

           Console.WriteLine($"Enter number of childs ");
                var ans = Console.ReadLine();
                numChild = Convert.ToInt16(ans);

                 Console.WriteLine($"Enter number of Adults ");
                var a = Console.ReadLine();
                numAdult = Convert.ToInt16(a);


          Console.WriteLine($" Do you want snacks? if yes press Y else N");
          var c = Console.ReadLine();
          choice = Convert.ToChar(c);
        
        if(choice == 'Y' || choice == 'y')
        {
            Console.WriteLine($"Select your choice ");

            Console.WriteLine($"Chips  Coke");
            var snacks = Console.ReadLine();

            switch(snacks.ToLower())

            {
                case "chips" : Console.WriteLine($"Enter the number of packs you want?");
                               var x = Console.ReadLine();   
                               var chipsCount = Convert.ToInt16(x);
                               break;

                case "coke"  : Console.WriteLine($"Enter the number of cokes you want?");
                               var y = Console.ReadLine();   
                               var cokesCount = Convert.ToInt16(y);
                               break;
                
                default      : break;              
                
            }
            
        }

        else
        {

        }

           
        

         
        }
    }
}
