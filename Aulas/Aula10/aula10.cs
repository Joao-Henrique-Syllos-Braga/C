using System;

class Aula10
{
    static void Main(){
        int n1 = 10;
        float n2= n1;

        float v1 = 10.5f;//daria erro se fizesse com a cima tem que fazer o type cast
        int v2=(int)v1; //type cast

        Console.WriteLine(n2);
        Console.WriteLine(v2);
    }
}