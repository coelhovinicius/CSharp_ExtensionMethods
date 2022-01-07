/* EXTENSION METHODS - Metodos de Extensao - estendem a funcionalidade de um tipo, sem alteracao do codigo-fonte e
 * sem necessidade de heranca desse tipo.
 * 
 * Exemplo 1: Criar um Extension Method chamado "ElapsedTime()", no Struct DateTime, para apresentar um objeto DateTime
 * na forma de tempo decorrido, podendo ser em horas (se menor que 24h), ou em dias, caso contrario.
 * 
 * Exemplo de entrada:
 *      DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
 *      Console.WriteLine(dt.ElapsedTime());
 *      
 * Exemplo de Saida:
 *      "4.5 hours"
 *      "3.2 days"
 *      
 * -------------------------------------------------- 
 * 
 * Exemplo 2: Criar um Extension Method chamado "Cut(int)", na classe String, para receber um valor inteiro como parametro
 * e gerar um recorte do string original daquele tamanho.
 * 
 * Exemplo de entrada:
 *      String s1 = "Good morning dear students!";
 *      Console.WriteLine(s1.Cut(10));
 *      
 * Exemplo de saida:
 *      "Good morni..."
 * 
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
//using Aula217_ExtensioMethods.Extensions;

//namespace Aula217_ExtensioMethods
//{
//class Program
public class Program
{
    //static void Main(string[] args)
    public static void Main()
    {
        // EXEMPLO 1:
        DateTime dt = new DateTime(2022, 1, 5, 10, 30, 45);
        Console.WriteLine(dt.ElapsedTime());

        Console.WriteLine();

        // EXEMPLO 2:
        string s1 = "Good morning dear students";
        Console.WriteLine(s1.Cut(15));
    }
}
//}
