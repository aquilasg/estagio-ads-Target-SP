using System;
using System.Text;

class progam
{

    static void Main(string[] args)
    {

        Console.WriteLine("Texto normal   : Texto escrito de maneira normal");
        string texto = "Texto escrito de maneira normal";
        StringBuilder sb = new StringBuilder();

        for (var i = texto.Length - 1; i >= 0; i--)
        {
            sb.Append(texto[i]);
        }
        Console.WriteLine("Texto invertido: " + sb.ToString());
    }

}