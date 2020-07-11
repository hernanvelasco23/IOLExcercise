using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Utilities.Resources;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal lado;
        public string Name => LanguageResource.Rectangle;
        public string PluralName => LanguageResource.RectanglePl;

        public Rectangulo(decimal lado)
        {
            this.lado = lado;
        }
        public decimal CalcularArea()
        {
            throw new NotImplementedException();
        }

        public decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
      
    }
}
