namespace example3
{
    public class Toriel : ICombatant
    {
        public Toriel()
        {
            HP = 480;
        }
        public string Name { get { return nameof(Toriel); } }
        public int HP { get; set; }
        public int AT { get { return 80; } }
        public int DF { get { return 80; } }
    }
}
