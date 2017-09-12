namespace example3
{
    public class Chara : Human, ICombatant
    {
        public Chara()
        {
            HP = 92;
            MRD = 16;
        }
        public string Name { get { return nameof(Chara); } }
        public int HP { get; set; }
        public int AT { get { return 46; } }
        public int DF { get { return 14; } }
        public int EXP { get { return 50000; } }
        public int LV { get { return 19; } }
    }
}
