using System;

class Aula
{
    static void Main()
    {
        int[] num = new int[5]{11,22,33,44,55};

        // for (int i = 0; i < num.Length; i++)
        // {
        //     Console.WriteLine(num[i]);
        // };

        foreach(int x in num){
            Console.WriteLine(x);
        };
    }
}