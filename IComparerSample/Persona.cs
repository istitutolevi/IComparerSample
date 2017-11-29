using System;


namespace IComparerSample
{
public class Persona
{
    public Persona()
    {}

    public Persona(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public string Nome { get; set; }
    public int Eta { get; set; }

    public static Persona Parse(string s)
    {
        string[] parts = s.Split(';');
        if (parts.Length != 2)
            throw new FormatException();

        Persona p = new Persona();
        p.Nome = parts[0];
        p.Eta = int.Parse(parts[1]);

        return p;
    }

    public override string ToString()
    {
        return string.Format("{0} ({1})", Nome, Eta);
    }
}
}