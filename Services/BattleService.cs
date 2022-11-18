using ConsoleAppDemo.Interface;
using ConsoleAppDemo.Models;
using ConsoleAppDemo.Models.Monsters;

namespace ConsoleAppDemo.Services
{
    internal class BattleService
    {
        public ICharacter StartBattle(Player player, Enemy enemy)
        {
            Console.WriteLine($"Battle between {player.Name} and {enemy.Name} has started");
            
            while (player.Health > 0 && enemy.Health > 0)
            {
                NextFightingRound(player, enemy);
            }

            Console.WriteLine($"Battle has ended");

            ICharacter winner = player.Health > 0 ? player : enemy;
            return winner;
        }

        //Randomize who will attack each round
        public void NextFightingRound(Player player, Enemy enemy) {
            
            var random = new Random();
            var isTrueThenEnemyStarts = random.NextDouble() >= 0.5;
            
            if (isTrueThenEnemyStarts)
                player.TakeDamage(enemy.Attack());
            else
                enemy.TakeDamage(player.Attack());
            
            Thread.Sleep(2000);
        }
    }
}
