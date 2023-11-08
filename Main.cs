// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Main
{

    public class Game
    {

        public static void Main(string[] args)
        {

           Random random = new Random();
            bool playagain = true ;
            string player;
            string pc;
            string answer;

            while (playagain)
            {
                player = "";
                pc = "";
                answer = "";
                while (player != "pedra" && player != "papel" && player != "tesoura")
                {
                    Console.WriteLine("Bem vindo ao jogo joken po, eu espero que você possa se divertir!!!");
                    Console.Write("Coloque pedra papel ou tesoura: ");
                    player = Console.ReadLine();
                }
                switch (random.Next(1,3))
                    {
                        case 1:
                            pc = "pedra";
                            break;
                        case 2:
                            pc = "papel";
                            break;
                        case 3:
                            pc = "tesoura";
                            break;
                    }
                Console.WriteLine($"Máquina: {pc}");
                Console.WriteLine($"Jogador: {player}");

                switch (player)
                {
                    case "pedra":
                        if (pc == "pedra")
                        {
                            Console.WriteLine("Empate zé");
                        }
                        else if (pc == "papel")
                        {
                            Console.WriteLine("perdeu zé");
                        }
                        else 
                        {
                            Console.WriteLine("Ganhou zé");
                        }
                        break;
                    case "papel":
                        if (pc == "papel")
                        {
                            Console.WriteLine("Empate zé");
                        }
                        
                     else if (pc == "tesoura")
                        {
                            Console.WriteLine("perdeu zé");
                        }
                        else
                        {
                            Console.WriteLine("Ganhou zé");
                        }
                        break;
                    case "tesoura":
                        if (pc == "tesoura")
                        {
                            Console.WriteLine("Empate zé");
                        }

                        else if (pc == "pedra")
                        {
                            Console.WriteLine("perdeu zé");
                        }
                        else
                        {
                            Console.WriteLine("Ganhou zé");
                        }
                        break;
                }
                Console.WriteLine("Quer continuar a jogar, Sim ou Não ?");
                answer = Console.ReadLine();
                if (answer == "Sim" || answer == "sim" || answer == "s")
                {
                    playagain = true;
                }
                else if (answer == "Não" || answer == "não" || answer == "n")
                {
                    playagain = false;
                }

                
            }
            Console.WriteLine("I hope you enjoyed the game");
        }
    
    
    
    }


}
