using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeRefresher
{
    internal class Program
    {
        static List<Player> players = new List<Player>();//Create a global list to hold new Player objects
        static void Main(string[] args)
        {
            players.Add(new Player("Belle", 10));//Add 5 players;
            players.Add(new Player("Meili", 5));
            players.Add(new Player("Alice", 7));
            players.Add(new Player("Charlie", 8));
            players.Add(new Player("Raymond", 3));
            
           
            while (true)//use loop to let user choose what information they want;
            {
                Console.WriteLine("\nPlease enter you choice:");
                Console.WriteLine("1. Display all players");
                Console.WriteLine("2. Display players with odd numbers");
                Console.WriteLine("3. Display players with names that start with a letter");
                Console.WriteLine("4. Add a new player");
                Console.WriteLine("5. Exit");

                string userinput = Console.ReadLine();
                int Userinput = int.Parse(userinput);

                switch (Userinput) //use swith to display the different case;
                {
                    case 1:
                        DisplayAllPlayers();
                        Userinput = -1;
                        break;
                    case 2:
                        DisplayPlayersWithOddNumbers();
                        break;
                    case 3:
                        DisplayPlayersWithNameStartWithALetter();
                        break;
                    case 4:
                        AddANewPlayer();
                        break;
                    case 5:
                        return;
                }
                
            }   
        }
        static void DisplayAllPlayers() //display all players;
        {
            Console.WriteLine("\nAll Players:");
            foreach (Player player in players) //use foreach to display all the player in player list;
            {              
                    Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");             
            }
        }

        static void DisplayPlayersWithOddNumbers() //Display Players With Odd Numbers;
        {
            Console.WriteLine("\nDisplay Player with Odd Numbers");
            foreach(Player player in players) //use foreach to display the user with odd numbers;
            {
                if (player.Number % 2 != 0) //use mod to check the number;
                {
                    Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
                }
            }
        }

        static void DisplayPlayersWithNameStartWithALetter()//Display Players With Name Start WithA Letter;
        {
            Console.WriteLine("\nPlease enter A Letter:");//let user enter a letter;
            char startingLetter = char.ToLower(Console.ReadLine()[0]);//use a vairable startingLetter to save the user entered letter;
            Console.WriteLine($"\nPlayers with names starting with '{startingLetter}':");
            int count = 0; //creat a vairable called count
            foreach (Player player in players) //use foreach to display the play the first letter equals the letter that user entered.
            {
                if (char.ToLower(player.Name[0]) == startingLetter) //use if to check if the first letter is equeal.
                {
                    Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
                    count++;//if user entered letter found in the player count add 1;
                }
            }
            if (count == 0)
                Console.WriteLine("doesn't exist!"); //if count still equal 0, that means the user entered letter doesn't found in the player list.
        }

        static void AddANewPlayer()// Add A New Player;
        {
            Console.WriteLine("\nPlease Enter a player's name:");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease Enter a player's number:");
            int number = int.Parse(Console.ReadLine());
            players.Add(new Player(name, number));  //use Add to add new player to player list
            DisplayAllPlayers();  //display the player list;
            Console.WriteLine("new player added!");
        }           
    }
}
