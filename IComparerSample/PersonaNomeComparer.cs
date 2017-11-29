using System;
using System.Collections.Generic;

namespace IComparerSample
{
    public class PersonaNomeComparer : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            // string implementa IComparable (che ha gli stessi valori di ritorno di IComparer)
            return x.Nome.CompareTo(y.Nome);
        }
    }
}