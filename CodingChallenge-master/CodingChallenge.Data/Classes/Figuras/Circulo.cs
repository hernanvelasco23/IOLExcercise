using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Utilities.Resources;
using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal lado;
        public string Name => LanguageResource.Circle;
        public string PluralName => LanguageResource.CirclePl;

        public Circulo(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }
       
    }
}
