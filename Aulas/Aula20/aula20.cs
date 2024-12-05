using System;

//Metodos

class Aula20
{
    static void Main()
    {
        print("Olá");
        soma(getNumbers(), getNumbers());
        
    }

    static void print(string text){
        Console.WriteLine(text);
    }

    static void soma(int n1, int n2){
        print(Convert.ToString(n1+n2));
    }

    static int getNumbers(){
        Console.WriteLine("Digite um numero");
        int n1 = int.Parse(Console.ReadLine());

        return n1;
    }

    

    //Metodo --> conjunto de instruções que serão executadas ao longo do codigo

}