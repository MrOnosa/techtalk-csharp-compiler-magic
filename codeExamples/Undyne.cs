namespace example3
{
    public class Undyne : ICombatant
    {
        public Undyne()
        {
            HP = 1500;
        }
        public string Name { get { return nameof(Undyne); } }
        public int HP { get; set; }
        public int AT { get { return 50; } }
        public int DF { get { return 20; } }
    }
}
