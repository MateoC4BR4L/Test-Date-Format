using System.Collections;
using System.Linq;
namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        string[,] DiaMesAño = new string[2,3] {{"", "", ""}, {"", "", ""}};
        char[] comparador = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        string dateFinal = "";
        bool confirmar = true;
        int lugar1 = 0;
        int lugar2 = 0;

        foreach(var i in date)
        {
            if(comparador.Contains(i))
            {
                DiaMesAño[lugar1, lugar2] += i.ToString();

            }
            else if(i.Equals('/') || i.Equals('-'))
            {
                lugar2 += 1;
            }
            else
            {
                confirmar = false;
            }
        }
        
        if(date.Length != 10 || confirmar == false)
        {
            return "La fecha ingresada es inválida.";
        }
        else
        {
            lugar1 += 1;
            for(int i = 0; i < 3; i++)
            {
                DiaMesAño[lugar1, i] = DiaMesAño[lugar1 -1, lugar2];
                lugar2 -= 1;
                dateFinal += DiaMesAño[lugar1, i];

                if(i < 2) dateFinal += date.ToArray().Contains('/')? "-" : "/";

            }
            return dateFinal;
        }
        
    }
}
