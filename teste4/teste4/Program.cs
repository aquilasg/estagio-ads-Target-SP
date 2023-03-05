using System;
using System.Globalization;

class program
{

    static void Main(string[] args)
    {

        double SP, RJ, MG, ES, outros;

        SP = 67836.43;
        RJ = 36678.66;
        MG = 29229.88;
        ES = 27165.48;
        outros = 19849.53;

        double total = SP + RJ + MG + ES + outros;

        Console.WriteLine("Percentual de representação que cada estado teve dentro do valor total mensal da distribuidora:");

        SP = SP / total * 100;
        Console.WriteLine("SP = " + SP.ToString("F2", CultureInfo.InvariantCulture) + "%");

        RJ = RJ / total * 100;
        Console.WriteLine("RJ = " + RJ.ToString("F2", CultureInfo.InvariantCulture) + "%");

        MG = MG / total * 100;
        Console.WriteLine("MG = " + MG.ToString("F2", CultureInfo.InvariantCulture) + "%");

        ES = ES / total * 100;
        Console.WriteLine("ES = " + ES.ToString("F2", CultureInfo.InvariantCulture) + "%");

        outros = outros / total * 100;
        Console.WriteLine("Outros = " + outros.ToString("F2", CultureInfo.InvariantCulture) + "%");
    }
}