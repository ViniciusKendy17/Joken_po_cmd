// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Main
{

    public class Game
    {
        static void TypeEffect(string texto)
        {
            foreach (char caractere in texto)
            {
                Console.Write(caractere);
                Thread.Sleep(60); 
            }

            Console.WriteLine(); 
        }

        public static void Main(string[] args)
        {

           Random random = new Random();
            bool playagain = true ;
            string player;
            string player0;
            string pc;
            string answer;
            string texto2;
            string texto1;

            while (playagain)
            {
                player = "";
                player0 = ""; 
                pc = "";
                answer = "";

                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    
                    texto1 = "Welcome to ROCK SCISSORS PAPER, you probably already know the rules, then LET'S PLAY !!!";
                    TypeEffect(texto1);
                    Console.WriteLine("--------------------------");
                    Console.Write("Pick: ROCK SCISSORS PAPER:  ");
                    player0 = Console.ReadLine();
                    player = player0.ToLower();
                    texto2 = "ROCK...SCISSORS...PAPER";
                    TypeEffect(texto2);

                }
                switch (random.Next(1,3))
                    {
                        case 1:
                            pc = "rock";
                            break;
                        case 2:
                            pc = "paper";
                            break;
                        case 3:
                            pc = "scissors";
                            break;
                    }

                Console.WriteLine("--------------------------");
                Console.WriteLine($"Machine: {pc}");
                Console.WriteLine($"You: {player}");
                Console.WriteLine("--------------------------");

                if(player == pc)
                {
                    Console.WriteLine("It's a draw");
                    Console.WriteLine("-------------------------");
                }
                else if (player == "paper" && pc == "scissors" || 
                         player == "scissors" &&  pc == "paper" ||
                         player == "paper" && pc == "rock")
                {
                    Console.WriteLine("You Won !!");
                    Console.WriteLine("-------------------------");
                }
                else
                {
                    Console.WriteLine("Loser lol");
                    Console.WriteLine("--------------------------");
                }

                Console.WriteLine("Want to play again (y) or (n) ?");
                answer = Console.ReadLine();
                if (answer == "y" || answer == "Y" || answer == "yes")
                {
                    playagain = true;
                }
                else if (answer == "n" || answer == "N" || answer == "no")
                {
                    playagain = false;
                }
               
            }
            Console.WriteLine("I hope you enjoyed the game");
        }
    
    
    
    }


}
