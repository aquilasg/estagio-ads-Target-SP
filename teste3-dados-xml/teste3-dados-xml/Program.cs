using System;
using System.Globalization;

class program
{

    static void Main(string[] args)
    {

        double[] valor = new double[30];

        valor[0] = 31490.7866;
        valor[1] = 37277.9400;
        valor[2] = 37708.4303;
        valor[3] = 0.0;
        valor[4] = 0.0;
        valor[5] = 17934.2269;
        valor[6] = 0.0;
        valor[7] = 6965.1262;
        valor[8] = 24390.9374;
        valor[9] = 14279.6481;
        valor[10] = 0.0000;
        valor[11] = 0.0000;
        valor[12] = 39807.6622;
        valor[13] = 27261.6304;
        valor[14] = 39775.6434;
        valor[15] = 29797.6232;
        valor[16] = 17216.5017;
        valor[17] = 0.0000;
        valor[18] = 0.0000;
        valor[19] = 12974.2000;
        valor[20] = 28490.9861;
        valor[21] = 8748.0937;
        valor[22] = 8889.0023;
        valor[23] = 17767.5583;
        valor[24] = 0.0000;
        valor[25] = 0.0000;
        valor[26] = 3071.3283;
        valor[27] = 48275.2994;
        valor[28] = 10299.6761;
        valor[29] = 39874.1073;

        // Menor valor faturado
        double menorValor = valor[0];
        for (int i = 0; i < 30; i++)
        {
            if (valor[i] < menorValor && valor[i] != 0)
            {
                menorValor = valor[i];
            }
        }

        Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês foi de " + menorValor.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine();

        // Maior valor faturado
        double maiorValor = valor[0];
        for (int i = 0; i < 30; i++)
        {
            if (valor[i] > maiorValor && valor[i] != 0)
            {
                maiorValor = valor[i];
            }
        }

        Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês foi de " + maiorValor.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine();

        // Média mensal
        double somaValores = 0.0;
        int contValores = 0;

        for (int i = 0; i < 30; i++)
        {
            if (valor[i] != 0)
            {
                somaValores = somaValores + valor[i];
                contValores++;
            }
        }
        double media = somaValores / contValores;

        // Número de dias no mês com faturamento diário superior à média mensal
        int contFatDiario = 0;
        for (int i = 0; i < 30; i++)
        {
            if (valor[i] != 0 && valor[i] > media)
            {
                contFatDiario++;
            }
        }
        Console.WriteLine("Número de dias no mês com faturamento diário superior à média mensal: " + contFatDiario);
    }
}