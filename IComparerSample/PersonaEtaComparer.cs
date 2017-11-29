using System;
using System.Collections.Generic;

namespace IComparerSample
{
public class PersonaEtaComparer : Comparer<Persona>
{
    public override int Compare(Persona x, Persona y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        return x.Eta.CompareTo(y.Eta);
    }
}
}