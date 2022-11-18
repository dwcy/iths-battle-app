namespace ConsoleAppDemo.Models.Monsters
{
    public class Monster : Enemy
    {
        public Monster(string name, int health = 100, int strength = 10)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public void MonsterAttack() => Console.WriteLine("Monster Attack");

        public override void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void WhenDesroyed()
        {
            Console.WriteLine($"Monster {Name} was destroyed");
        }
    }
}
