using System;


class Aula16
{
    static void Main()
    {
        int[] num = new int[10];

        int i = 1;
        
        while(i < num.Length){
            num[i] = i;
            Console.WriteLine(num[i]);
            i++;
        };
    }
}