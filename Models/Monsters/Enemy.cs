using ConsoleAppDemo.Interface;

///base class for all monsters
namespace ConsoleAppDemo.Models.Monsters
{
    public abstract class Enemy : IEnemy, ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public int StartHealth = 0;
 
        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} was hit for {damage} damage. Health is now {Health}/{StartHealth}");

            if (Health <= 0)
                OnDeath();
        }

        public virtual int Attack() => Strength;

        public virtual void OnDeath()
        {
            Console.WriteLine($"{Name} was slayed!");
        }
    }
}
