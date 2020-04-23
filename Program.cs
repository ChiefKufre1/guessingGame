using System.Dynamic;
using System.Reflection.Emit;
using System.Text;
using System.Globalization;
using System.Data;
using System;

namespace GuessGame
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int selectLevel;
             Console.WriteLine("Hello, welcome to the Guess Game");
            Console.Write("Please select the level to play ( Enter 1 for Easy, 2 for Medium and 3 for Hard): ");
            selectLevel = int.Parse(Console.ReadLine());

            if (selectLevel == 1)
            {
                EasyLevel();
                
            }

            else if (selectLevel == 2)
            {
                MediumLevel();
            }
            else if (selectLevel == 3)
            {
                HardLevel();
            }
            else
            {
                Console.WriteLine("Sorry, it seems you entered an incorrect entry");
                Console.ReadLine();

            }
        }
        
        
        static void  EasyLevel() {
        
        Console.WriteLine("Welcome to EasyLevel");

        int secretNumber = 7;
        int guess = 0;
    int guessCount = 0;
    int guessLimit = 6;
    bool outOfGuess = false;

    
        while (guess != secretNumber && !outOfGuess)
        {

            if (guessCount < guessLimit)
            {
               Console.WriteLine("Enter guess: ");
            guess = int.Parse(Console.ReadLine());
             guessCount++ ;
            }
            else
            {
                outOfGuess = true;

            }
            
        }
         if (outOfGuess)
            {
                Console.WriteLine("Oops, you lose");
                 
            }  
            else
            {
                Console.WriteLine("Oops, you won");
            }

            Console.ReadLine();

}           
        

        static void MediumLevel() {

Console.WriteLine("Welcome to MediumLevel");
        
        int secretNumber = 17;
        int guess = 0;
    int guessCount = 0;
    int guessLimit = 4;
    bool outOfGuess = false;

    
        while (guess != secretNumber && !outOfGuess)
        {

            if (guessCount < guessLimit)
            {
               Console.WriteLine("Enter guess: ");
            guess = int.Parse(Console.ReadLine());
             guessCount++ ;
            }
            else
            {
                outOfGuess = true;

            }
            
        }
         if (outOfGuess)
            {
                Console.WriteLine("Game Over!");
                 
            }  
            else
            {
                Console.WriteLine("You got it right!");
            }

            Console.ReadLine();

        
        }

        static void HardLevel ()
        {
        Random randomNumber = new Random();
        int guessNumber = randomNumber.Next (1, 51);

        int guesses = 0;
        int guessCount = 0;
        int guessLimit = 3;
        bool incorrect = true;

        Console.Clear();

        guessCount++;

        if (guessCount < guessLimit)
        {
            
            do
        {
            Console.WriteLine("Guess a number between 1 and 50; ");
            string result = Console.ReadLine();
            guesses++;

        if ( result == guessNumber.ToString())
            incorrect = false;
            else
            {
                Console.WriteLine("That was wrong");
            }

        } while (incorrect);

        Console.WriteLine("You got it right!");
Console.ReadLine();
        }

        else if (guessCount > guessLimit)
        {
            Console.WriteLine("Game over!");
            
        }
       int guessLimit = int.Parse(Console.ReadLine()) ;
        }
        




    }   
    }

