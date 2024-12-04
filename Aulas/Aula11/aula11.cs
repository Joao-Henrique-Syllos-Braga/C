using System;

class Aula11
{
    static void Main()
    {
        float n1;

        Console.WriteLine("Digite um numero:");

        n1 = int.Parse(Console.ReadLine());

        if (n1 > 10) {
            Console.WriteLine("{0} é maior que 10!", n1);
        } 
        else if (n1 == 10){
            Console.WriteLine("{0} é igual á 10!", n1);
        }
        else {
            Console.WriteLine("{0} é menor que 10!", n1);
        }
    }
}