using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("20d2");
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }
        static void ThrowDice(string diceString)
        {
            //splitting diceString on 'd' to put it into two lists,
            // one meaning how many rolls, the other how many sides
            string[] splitD = diceString.Split('d');

            //this string indicates how many times to roll
            string rollNumber = splitD[0];

            //this string indicates how many sides it has
            string rollSides = splitD[1];

            int total = 0;

            //Creating a random number gen
            Random randomNumberGenerator = new Random();

            Console.WriteLine("\n\n\n============================= NEW ROLL FOR " + diceString + "===============================");

            //the loop picking the random number per roll and for x amount of sides.
            for (int i = 1; i <= int.Parse(rollNumber); i++)
            {
                //put this in the loop so you don't get the same number 20 times
                int randomNumber = randomNumberGenerator.Next(1, int.Parse(rollSides) + 1);

                total += randomNumber;
                //so they all stay on the same line
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine("\n\n The average of the rolls was...");
            Console.WriteLine(total / int.Parse(rollNumber));
        }
    }
}
