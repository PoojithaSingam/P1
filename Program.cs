using System;

namespace P1
{
    class Program
    {
         public static double calcTotalCost(int numChild,int numAdult,double ticketPriceAdult,double ticketPriceChild,double total){
            return numChild*ticketPriceChild+numAdult*ticketPriceAdult+total;
        }
        static void Main(string[] args)
        {
            var ticketPriceChild = 15.0;
            var ticketPriceAdult = 20.0;
            var chipsPrice = 5.0;
            var cokePrice = 7.0;
            var cokechipspackPrice = 12.0;
            var numChild = 0;
            var numAdult = 0;
            var name = "";
            var totalCost = 0.0m;
            var exit = false;
            var choice = 'a';
            var total=0.0;
            
            do{

            Console.WriteLine("Hello there!!");

             while(name == "")
            {
                Console.WriteLine($"Please enter your name: ");
                name = Console.ReadLine();
                
            }
             Console.WriteLine($"Welcome to DisneyLand {name} !!!!");
      

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

            Console.WriteLine($"Chips - 5$ \n Coke - 7$ \n Both - 11$");
            var snacks = Console.ReadLine();

            switch(snacks.ToLower())

            {
                case "chips" : Console.WriteLine($"Enter the number of packs you want?");
                               var x = Console.ReadLine();   
                                var chipsCount = Convert.ToInt16(x);
                                total = chipsCount * chipsPrice;
                               break;

                case "coke"  : Console.WriteLine($"Enter the number of cokes you want?");
                               var y = Console.ReadLine();   
                                var cokesCount = Convert.ToInt16(y);
                                total = cokesCount * cokePrice;
                               
                               break;
                case "both"  :  Console.WriteLine($"Enter the number of packs you want?");
                                var g = Console.ReadLine();
                                var count = Convert.ToInt16(g);
                                total = count * cokechipspackPrice;
                                break;      
        
                
                default      : break;              
                
                
            }
           
           
            
        }
        var totalPrice=Program.calcTotalCost(numChild,numAdult,ticketPriceAdult,ticketPriceChild,total);
        totalCost = Convert.ToDecimal(totalPrice);
            Console.WriteLine($"Your total amount is {totalCost}$. \n Have a good day {name}!!!!");
            Console.WriteLine($"Press y to exit or press any key to continue");
            var z = Console.ReadLine();
            if(z == "y" || z == "Y")
            {
                exit = true;
            }
            }
            while(exit == false);
    }
    }
}