using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code

            Random rnd = new Random();
            int digit1 = rnd.Next(1, 9);
            int digit2 = rnd.Next(0, 9);
            int digit3 = rnd.Next(0, 9);
            int digit4 = rnd.Next(0, 9);
            string valid = " ";

            while (valid == " ")
            {
                if (digit1 == digit2)
                {
                    digit2 = rnd.Next(0, 9);
                }

                if (digit1 == digit3)
                {
                    digit3 = rnd.Next(0, 9);
                }

                if (digit1 == digit4)
                {
                    digit4 = rnd.Next(0, 9);
                }

                if (digit2 == digit3)
                {
                    digit3 = rnd.Next(0, 9);
                }

                if (digit2 == digit4)
                {
                    digit4 = rnd.Next(0, 9);
                }

                if (digit3 == digit4)
                {
                    digit4 = rnd.Next(0, 9);
                }

                if (digit1 == digit2 || digit1 == digit3 || digit1 == digit4 || digit2 == digit3 || digit2 == digit4 || digit3 == digit4)
                {
                    valid = " ";
                }
                else
                {
                    valid = "yes";
                }
            }
            //Console.WriteLine((digit1.ToString()) + (digit2.ToString()) + (digit3.ToString()) + (digit4.ToString()));

            string validGuess = " ";
            string UserGuess = "    ";
            int UserGuessInt = 0;

            Console.WriteLine("Enter a 4 digit number (within range 1000-9999 and no repeating digits): ");
            UserGuess = Console.ReadLine();
            string GuessD1 = UserGuess.Substring(0, 1);
            string GuessD2 = UserGuess.Substring(1, 1);
            string GuessD3 = UserGuess.Substring(2, 1);
            string GuessD4 = UserGuess.Substring(3, 1);

            int GuessLength = 0;

            //Console.WriteLine(GuessD1 + "," + GuessD2 + "," + GuessD3 + "," + GuessD4);
            int NumOfGuesses = 0;
            int bulls = 0;

            while (validGuess != "yes" || bulls != 4)
            {
                UserGuess = Console.ReadLine();

                if (GuessD1 == GuessD2 || GuessD1 == GuessD3 || GuessD1 == GuessD4 || GuessD2 == GuessD3 || GuessD2 == GuessD4 || GuessD3 == GuessD4)
                {
                    validGuess = "no";
                    UserGuess = Console.ReadLine();
                }

                GuessLength = UserGuess.Length;

                if (GuessLength != 4)
                {
                    validGuess = "no";
                }

                UserGuessInt = Convert.ToInt32(UserGuess);
                if (UserGuessInt > 9999 || UserGuessInt < 1000)
                {
                    validGuess = "no";
                }

                if (validGuess != " ")
                {
                    validGuess = "yes";
                }
                NumOfGuesses = NumOfGuesses + 1;
            }
            int GuessIntD1 = Convert.ToInt32(GuessD1);
            int GuessIntD2 = Convert.ToInt32(GuessD2);
            int GuessIntD3 = Convert.ToInt32(GuessD3);
            int GuessIntD4 = Convert.ToInt32(GuessD4);

            int cows = 0;


            if (GuessIntD1 == digit1 || GuessIntD1 == digit2 || GuessIntD1 == digit3 || GuessIntD1 == digit4)
            {
                cows = cows + 1;
            }
            if (GuessIntD2 == digit1 || GuessIntD2 == digit2 || GuessIntD2 == digit3 || GuessIntD2 == digit4)
            {
                cows = cows + 1;
            }
            if (GuessIntD3 == digit1 || GuessIntD3 == digit2 || GuessIntD3 == digit3 || GuessIntD3 == digit4)
            {
                cows = cows + 1;
            }
            if (GuessIntD4 == digit1 || GuessIntD4 == digit2 || GuessIntD4 == digit3 || GuessIntD4 == digit4)
            {
                cows = cows + 1;
            }
            Console.WriteLine("Cows: " + cows);



            if (GuessIntD1 == digit1)
            {
                bulls = bulls = 1;
            }
            if (GuessIntD2 == digit2)
            {
                bulls = bulls = 1;
            }
            if (GuessIntD3 == digit3)
            {
                bulls = bulls = 1;
            }
            if (GuessIntD4 == digit4)
            {
                bulls = bulls = 1;
            }
            Console.WriteLine("Bulls: " + bulls);

            if (bulls == 4)
            {
                Console.WriteLine("You made " + NumOfGuesses + " guesses");
            }

        }
    }
}
