namespace ConsoleAppDemo.Interface
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        int Strength { get; set; }
        void TakeDamage(int damage);
        void OnDeath();
    }
}
