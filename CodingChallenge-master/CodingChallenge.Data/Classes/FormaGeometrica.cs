/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */
using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Utilities.Resources;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometrica> formas, ILanguage idioma)
        {
            var sb = new StringBuilder();
            
            CultureInfo culture = CultureInfo.CreateSpecificCulture(idioma.Culture);
            CultureInfo.CurrentUICulture = new CultureInfo(idioma.Culture, false);

            if (!formas.Any())
            {
                sb.Append($"<h1>{LanguageResource.EmptyList}!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{LanguageResource.Header}</h1>");

                var totales = (from s in formas
                               group s by new { s.Name, s.PluralName } into totalGroup
                               select new Result(totalGroup.Key.Name, totalGroup.Key.PluralName, totalGroup.Count(),
                                totalGroup.Sum(f => f.CalcularPerimetro()),totalGroup.Sum(f => f.CalcularArea())
                               )).ToList();

                foreach (var forma in totales)
                {
                    sb.Append(ObtenerLinea(forma.Total, forma.TotalArea, forma.TotalPer, forma.Nombre, forma.NombrePlural));
                }

                // FOOTER
                sb.Append($"{LanguageResource.Total}:<br/>{totales.Sum(x => x.Total)} {LanguageResource.Shapes} {LanguageResource.Perimeter} {totales.Sum(x => x.TotalPer):#.##} {LanguageResource.Area} {totales.Sum(x => x.TotalArea):#.##}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string nombre, string plural)
        {
            if (cantidad > 0)
                return $"{cantidad} {(cantidad==1? nombre : plural)} | {LanguageResource.Area} {area:#.##} | {LanguageResource.Perimeter} {perimetro:#.##} <br/>";

            return string.Empty;
        }
    }
}
