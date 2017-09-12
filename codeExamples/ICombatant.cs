namespace example3
{
    internal interface ICombatant
    {
        string Name { get; }
        int HP { get; set; }
        int AT { get; }
        int DF { get; }
    }
}
