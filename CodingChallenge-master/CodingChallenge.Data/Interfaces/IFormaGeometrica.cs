
namespace CodingChallenge.Data.Interfaces
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string Name { get; }
        string PluralName { get;}
    }
}
