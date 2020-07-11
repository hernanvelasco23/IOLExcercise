using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Utilities.Resources;
using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero:IFormaGeometrica
    {
        public readonly decimal lado;
        public string Name => LanguageResource.Triangle;
        public string PluralName => LanguageResource.TrianglePl;

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 3;
        }
    }
}
