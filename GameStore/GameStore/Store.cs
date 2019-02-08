using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Store
    {
        int maxGames = 4;
        List<Game> showcase = new List<Game>();

        public Store()
        {
            showcase.Add(new Game("FPS", 15f, "Call of Duty", "Player vs player competetive game"));
            showcase.Add(new Game("MMO/RPG", 10f, "Diablo 3", "Welcome to the endless grind :)"));
            showcase.Add(new Game("Shooter/Battleroyale", 0f, "Fortnite", "Worlds most played battleroyale"));
        }

        public void AddGame(Game game)
        {   
            if(showcase.Count<maxGames)
            showcase.Add(game);
        }

        public void RemoveGame(Game game)
        {
            if(showcase.Contains(game))
            showcase.Remove(game);
        }

        public void SellGame(Game game, User user)
        {
            if (user.wallet >= game.price)
            {
                user.library.Add(game);
                user.wallet = user.wallet - game.price;
                RemoveGame(game);
            }
            else
                Console.WriteLine("Not enough funds! :(");
        }
    }

    class User
    {
        public float wallet;
        public List<Game> library=new List<Game>();

        public User(float wallet)
        {
            this.wallet = wallet;
        }
    }

    class Game
    {
        public string genre;
        public string name;
        public float price;
        public string description;

        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }
    }
  
  
    class DLC
    {

    }
}
