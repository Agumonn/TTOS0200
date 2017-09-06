using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Blackjack
    {
        public static void PlayBJ()
        {
            int myNumber = 17;
            int theirNumber;
            int apu = 0;
            while (apu == 0)
            {
                System.Console.WriteLine("*** BlackJack! ***");
            System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
            theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
            //comparing that given umber is valid

               
                    //comparing
                    if (theirNumber >= myNumber && theirNumber <= 21 && theirNumber > 0)
                    {
                        System.Console.WriteLine("You win.");
                        theirNumber = 0;
                    }
                    else if(theirNumber <= myNumber && theirNumber <= 21 && theirNumber > 0)
                    {
                        System.Console.WriteLine("You lose.");
                        theirNumber = 0;
                    }
                    else if(theirNumber >= 22 || theirNumber==0)
                    {
                    System.Console.WriteLine("Your number was 0 or higher than 21 game ends");
                    apu++;
                    }
            }
            
        }
    }
}
