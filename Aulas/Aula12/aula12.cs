using System;

class Aula12
{
    static void Main()
    {
        string escolha;

        inicio:
        Console.Clear();

        Console.WriteLine("Escolha entre (a), (b)");

        escolha = Console.ReadLine();

        int pontos = 0;

        switch(escolha){
            case "a":
            case "A":
                pontos+=1000;
                break;
            case "b":
            case "B":
                pontos+=100;
                break;
            case "c":
            case "C":
                pontos+=10;
                break;
            default:
                Console.WriteLine("Valor invalido");
                break;
        };

        if (pontos > 2){
            Console.WriteLine("Obrigado pela informação");
        }

        Console.WriteLine("Deseja refazer s/n");
        escolha = Console.ReadLine();

        if (escolha == "s" || escolha == "S") {
            goto inicio;
        }else {
            Console.Clear();
            Console.WriteLine("Programa Finalizado");
        }
    }
}