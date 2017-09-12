namespace example3
{
    public class Asgore : ICombatant
    {
        public Asgore()
        {
            HP = 3500;
        }
        public string Name { get { return nameof(Asgore); } }
        public int HP { get; set; }
        public int AT { get { return 80; } }
        public int DF { get { return 80; } }
    }
}
