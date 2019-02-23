using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Store store = new Store();
            User myUser = new User(100);
       
            
            while (true)
            {
                store.PrintShowcase();
                Console.WriteLine("Input command:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "buy":
                        Console.WriteLine("Which game?");
                        string buyInput = Console.ReadLine();
                        int gameN = int.Parse(buyInput);
                        if (store.IsValidGame(gameN))
                        {
                            store.SellGame(gameN, myUser);
                        }
                        else
                        {
                            Console.WriteLine("Invalid game");
                        }
                        
                        break;
                    case "add":

                        Console.WriteLine("Give name of game");
                        string name = Console.ReadLine();

                        Console.WriteLine("description of the game");
                        string desc = Console.ReadLine();

                        Console.WriteLine("price");
                        string price = Console.ReadLine();
                        float p = float.Parse(price);

                        Console.WriteLine("genre");
                        string genre = Console.ReadLine();

                        Game game = new Game(name, p, desc, genre);
                        store.AddGame(game);

                        
                        
                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
    }
}
