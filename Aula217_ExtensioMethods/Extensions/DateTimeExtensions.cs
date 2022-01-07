/* >>> CLASSE DATETIMEEXTENSIONS - ESTATICA <<< */
//using System;
using System.Globalization;

//namespace Aula217_ExtensioMethods.Extensions
namespace System /* Quando da criacao de um Extention Method para uma classe ou struct, e indicado que coloque esse 
                  * metodo no Namespace System */
{
    static class DateTimeExtensions // Classe Estatica
    {
        public static string ElapsedTime(this DateTime thisObj) // Funcao para retornar a duracao de tempo
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); /* Cria o periodo de tempo "duration", subtraindo o
                                                                 * "thisObj" (data informada) do DateTime atual */

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
