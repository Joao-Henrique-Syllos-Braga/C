using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            if(args.GetLenght(0)>0){
                Console.Write(args.GetValue(0));    
            }
        }
    }
}