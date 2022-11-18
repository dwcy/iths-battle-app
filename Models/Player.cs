using ConsoleAppDemo.Interface;

namespace ConsoleAppDemo.Models
{
    internal class Player : ICharacter
    {
        public Player(string name = "Player1")
        {
            Name = name;
            Health = 100;
            Strength = 10;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} was hit for {damage} damage. Health is now {Health}");

            if (Health <= 0)
                OnDeath();
        }

        public void HealthUp(int health)
        {
            Health += health;
        }

        public void PowerUp(int strength)
        {
            Strength += strength;
        }

        public void PowerDown(int strength)
        {
            Strength -= strength;
        }

        public void OnDeath()
        {
            Console.WriteLine($"Player {Name} was destroyed");
            Console.WriteLine($"Game Over!");
        }
       
        public virtual int Attack() => Strength;
    
    }
}
