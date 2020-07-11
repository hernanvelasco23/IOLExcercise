
namespace CodingChallenge.Data.Classes
{
    public class Result
    {
        public int Total { get; private set; }
        public decimal TotalPer { get; private set; }
        public decimal TotalArea { get; private set; }
        public string Nombre { get; private set; }
        public string NombrePlural { get; private set; }

        public Result(string nombre, string pluralNombre, int total, decimal totalPerimetro, decimal totalArea)
        {

            Nombre = nombre;
            NombrePlural = pluralNombre;
            Total = total;
            TotalArea = totalArea;
            TotalPer = totalPerimetro;
        }
    }
}
