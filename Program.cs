using ConsoleAppDemo.Models;
using ConsoleAppDemo.Models.Monsters;
using ConsoleAppDemo.Services;
namespace Demo;


public class Program
{

    public static void Main(string[] args)
    {
        var battleService = new BattleService();

        var player = new Player();
        var blob = new Blob("Bobby The Blobby", health: 50);

        var winner = battleService.StartBattle(player, blob);
        Console.WriteLine($"And the winner is: {winner.Name}");

        Console.ReadKey();
    }
} 


