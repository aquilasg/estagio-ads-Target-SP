using System;
using System.Globalization;

class program
{

    static void Main(string[] args)
    {

        double[] valor = new double[30];

        valor[0] = 22174.1664;
        valor[1] = 24537.6698;
        valor[2] = 26139.6134;
        valor[3] = 0.0;
        valor[4] = 0.0;
        valor[5] = 26742.6612;
        valor[6] = 0.0;
        valor[7] = 42889.2258;
        valor[8] = 46251.174;
        valor[9] = 11191.4722;
        valor[10] = 0.0;
        valor[11] = 0.0;
        valor[12] = 3847.4823;
        valor[13] = 373.7838;
        valor[14] = 2659.7563;
        valor[15] = 48924.2448;
        valor[16] = 18419.2614;
        valor[17] = 0.0;
        valor[18] = 0.0;
        valor[19] = 35240.1826;
        valor[20] = 43829.1667;
        valor[21] = 18235.6852;
        valor[22] = 4355.0662;
        valor[23] = 13327.1025;
        valor[24] = 0.0;
        valor[25] = 0.0;
        valor[26] = 25681.8318;
        valor[27] = 1718.1221;
        valor[28] = 13220.495;
        valor[29] = 8414.61;

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