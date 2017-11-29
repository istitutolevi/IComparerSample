using System;
using System.IO;

namespace IComparerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] persone = new[]
            {
                new Persona("Marco", 15),
                new Persona("Luca", 26),
                new Persona("Andrea", 32),
                new Persona("Giovanni", 12),
                new Persona("Stefano", 9),

            };

            Console.WriteLine("Disordinato");

            foreach (Persona persona in persone)
                Console.WriteLine(persona);

            Array.Sort(persone, new PersonaNomeComparer());

            Console.WriteLine();
            Console.WriteLine("Ordinato per nome");

            foreach (Persona persona in persone)
                Console.WriteLine(persona);

            Array.Sort(persone, new PersonaEtaComparer());

            Console.WriteLine();
            Console.WriteLine("Ordinato per eta");

            foreach (Persona persona in persone)
                Console.WriteLine(persona);

            Console.ReadLine();
        }
    }
}
