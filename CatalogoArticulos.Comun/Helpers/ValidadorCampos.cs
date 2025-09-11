using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatalogoArticulos.Comun
{
    public static class ValidadorCampos
    {
        public static bool EsTextoObligatorio(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        public static bool TieneLongitudMinima(string texto, int minimo)
        {
            return texto?.Trim().Length >= minimo;
        }

        public static bool TieneLongitudMaxima(string texto, int maximo)
        {
            return texto?.Trim().Length <= maximo;
        }

        public static string NormalizarTexto(string texto)
        {
            return texto?.Trim().ToUpper();
        }

        public static bool EsTextoValido(string texto, int minimo, int maximo)
        {
            return EsTextoObligatorio(texto)
                && TieneLongitudMinima(texto, minimo)
                && TieneLongitudMaxima(texto, maximo);
        }

        public static bool EsUrlDeImagen(string url)
        {
            // métdo para validar que las urls sean válidas 
            return !string.IsNullOrWhiteSpace(url)
                && (url.StartsWith("http://")
                    || url.StartsWith("https://"));
        }

    }
}
