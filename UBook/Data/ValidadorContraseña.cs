namespace UBook.Data;
using System;
using System.Text.RegularExpressions;

public class ValidadorContraseña
{
    public static string ValidarContraseña(string contraseña)
    {
        const int LongitudMínima = 8;

        // Verificar longitud mínima
        if (contraseña.Length < LongitudMínima)
        {
            var temp = "La contraseña debe tener al menos 8 caracteres.";
            return temp;
        }

        // Verificar al menos una mayúscula
        if (!tieneMayuscula(contraseña))
        {
            var temp = "La contraseña debe contener al menos una mayúscula.";
            return temp;
        }

        // Verificar al menos una minúscula
        if (!tieneMinuscula(contraseña))
        {
            var temp = "La contraseña debe contener al menos una minúscula.";
            return temp;
        }

        // Verificar al menos un número
        if (!tieneNumero(contraseña))
        {
            var temp = "La contraseña debe contener al menos un número.";
            return temp;
        }

        // Verificar al menos un carácter especial
        if (!tieneCaracterEspecial(contraseña))
        {
            var temp =  "La contraseña debe contener al menos un carácter especial.";
            return temp;
        }

        // La contraseña cumple con todos los criterios
        var temp2 =  "La contraseña es válida.";
        return temp2;
    }

    private static bool tieneMayuscula(string contraseña)
    {
        return Regex.IsMatch(contraseña, @"[A-Z]");
    }

    private static bool tieneMinuscula(string contraseña)
    {
        return Regex.IsMatch(contraseña, @"[a-z]");
    }

    private static bool tieneNumero(string contraseña)
    {
        return Regex.IsMatch(contraseña, @"\d");
    }

    private static bool tieneCaracterEspecial(string contraseña)
    {
        return Regex.IsMatch(contraseña, @"[^A-Za-z0-9]");
    }
}

