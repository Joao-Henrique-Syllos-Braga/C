using System;

class Aula07
{
    static void Main()
    {
        int v1,v2,soma;
        string nome;

        Console.WriteLine("Digite se nome");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.WriteLine("{0} digite um numero", nome);
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;

        Console.WriteLine("As soma entre {0} + {1} é {2}", v1, v2, soma);
    }
}