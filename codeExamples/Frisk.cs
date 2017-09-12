using System;

namespace example3
{
    public class Frisk : Human, ICombatant
    {
        public Frisk()
        {
            HP = 20;            
        }
        public string Name { get { return nameof(Frisk); } }
        public int HP { get; set; }
        public int AT { get { return 10; } }
        public int DF { get { return 10; } }
        public int EXP { get { return 0; } }
        public int LV { get { return 1; } }
    }
}
