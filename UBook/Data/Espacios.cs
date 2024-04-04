using System.Text.RegularExpressions;

public class EspaciosHelper
{
    public static bool ValidarCadena(string input)
    {
        // Eliminar espacios duplicados
        string sinEspaciosRepetidos = EliminarEspaciosRepetidos(input);

        // Validar si está vacío o contiene solo espacios
        return !string.IsNullOrWhiteSpace(sinEspaciosRepetidos);
    }

    public static string EliminarEspaciosRepetidos(string input)
    {
        // Utilizar expresión regular para eliminar espacios duplicados
        string patron = "\\s+";
        string reemplazo = " ";
        string resultado = Regex.Replace(input, patron, reemplazo);

        return resultado.Trim();  // Eliminar espacios al principio y al final
    }

    public static string EliminarTodosLosEspacios(string input)
    {
        // Reemplazar todos los espacios por una cadena vacía
        return input.Replace(" ", "");
    }

    public static bool TieneEspacios(string input)
    {
        // Verificar si la cadena contiene al menos un espacio
        return input.Contains(" ");
    }
}


//string cadena1 = "   Esto es  una   cadena  con espacios   duplicados  ";
//string cadena2 = "   ";  // Cadena con solo espacios
//string cadena3 = "";     // Cadena vacía
//string cadena4 = "Texto sin espacios";

//Console.WriteLine(EspaciosHelper.ValidarCadena(cadena1));  // Devuelve true
//Console.WriteLine(EspaciosHelper.ValidarCadena(cadena2));  // Devuelve false
//Console.WriteLine(EspaciosHelper.ValidarCadena(cadena3));  // Devuelve false
//Console.WriteLine(EspaciosHelper.ValidarCadena(cadena4));  // Devuelve true
