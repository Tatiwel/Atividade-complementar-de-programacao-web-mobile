namespace DestinoCerto.Models
{
  public class Endereco
  {
    public string Cidade { get; }
    public string UF { get; }

    public Endereco(string cidade, string uf)
    {
      Cidade = cidade;
      UF = uf;
    }

    // Override Equals and GetHashCode methods for value object semantics
    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
        return false;

      Endereco other = (Endereco)obj;
      return Cidade == other.Cidade && UF == other.UF;
    }
  }
}
