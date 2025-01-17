using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VeterinaryCenter.Validations
{
    public class InputValidator
    {
        //Método para verificar si una cadena contiene solo letras y espacios
        public static bool IsAlphabetic(string value)
        {
            var regex = new Regex("^[a-zA-Z ]+$");
            return regex.IsMatch(value);
        }

        // Método para verificar si una cadena es numérica
        public static bool IsNumeric(string value)
        {
            return long.TryParse(value, out _);
        }

        // Método para validar un formato de fecha
        public static bool IsValidDate(string value, out DateOnly date)
        {
            return DateOnly.TryParse(value, out date);
        }
    }
}