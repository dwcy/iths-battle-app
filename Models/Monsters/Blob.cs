namespace ConsoleAppDemo.Models.Monsters
{
    public class Blob : Enemy
    {
        public Blob(string name, int health = 10, int strength = 3)
        {
            Name = name;
            Health = health;
            Strength = strength;
            
            StartHealth = Health;
        }
    }
}
