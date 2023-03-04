using System;

class program
{

    static void Main(string[] args)
    {

        int numero, i, a = 0, b = 1, aux;
        bool fibo;

        Console.WriteLine("Digite o número desejado: ");

        numero = int.Parse(Console.ReadLine());

        fibo = false;

        for (i = 0; i​​​​​​​ < numero; i++)
        {
            aux = a;
            a = b;
            b = a + aux;

            if (b == numero)
            {
                fibo = true;
                break;
            }
        }

        Console.WriteLine();

        if (fibo)
        {
            Console.WriteLine("O numero " + numero + " pertence a sequencia de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O numero " + numero + " nao pertence a sequencia de Fibonacci.");
        }
    }
}