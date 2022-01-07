/* >>> CLASSE STRINGEXTENSIONS - ESTATICA <<< */
namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count) /* Funcao para cortar uma string a partir de um numero
                                                                  * inteiro informado */
        {
            if (thisObj.Length <= count) // Se o comprimento da string for menor do que o numero inteiro informado
            {
                return thisObj; // Retorna a string, sem a necessidade de ser cortada
            }
            else
            {
                return thisObj.Substring(0, count) + "..."; // Retorna a string cortada, a partir da posicao 0
            }
        }
    }
}
