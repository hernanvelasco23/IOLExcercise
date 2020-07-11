using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Utilities.Resources;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal lado;
        public string Name => LanguageResource.Square;
        public string PluralName => LanguageResource.SquarePl;
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }
      
    }
}
