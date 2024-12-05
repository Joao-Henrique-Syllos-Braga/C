using System;

class Aula19
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{ { 11,22,00,44,55 } , { 66,77,88,99,00 } };


        // Cria um objeto rendom que será usado para sortear um numero
        Random random = new Random();
        for( int i = 0 ; i < vetor1.Length ; i++ ){
            vetor1[ i ] = random.Next( 50 ); // Adiciona um cada valor do array um valor até 50
        }

        foreach(int x in vetor1){
            Console.WriteLine( x );
        }

        // Public static int BinarySearch( array, valor )
        // É que nem o filter do python, mas mostra o indice do elemento igual

        Console.WriteLine( "BinarySearch");
        int search = 33;
        int pos = Array.BinarySearch(vetor1, search);
        Console.WriteLine( "Valor {0} está na posição {1}" , search , pos );

        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );

        // Public static void Copy(Array_origem, Array_destino, numero de elementos)
        Console.WriteLine( "Copy" );
        Array.Copy( vetor1, vetor2, vetor1.Length ); // Copia todos os elementos do vetor1 para o array vetor2
        Console.WriteLine( "Vetor 2:" );
        foreach( int x in vetor2 ){
            Console.WriteLine( x );
        }

        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );


        // Public void CopyTo(Array_destino,a_partir_desta_posição)
        Console.WriteLine( "CopyTo" );
        vetor1.CopyTo(vetor3, 0); // Copiar os elementos apartir do indice 0 do array vetor1 para o vetor3
        Console.WriteLine( "Vetor 3:" );
        foreach(int x in vetor3){
            Console.WriteLine( x );
        } 

        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );

        // Public long GetLongLength(dimensão)
        Console.WriteLine( "GetLongLength" );
        long qtdeElementosVetor = vetor1.GetLongLength(0);  // Retorna o numero de elementos nessa dimensão (Array[dimensão, 0])
        Console.WriteLine( "Quantidade de elementos {0}" , qtdeElementosVetor );

        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );
        
        //Public int GetLowerBound(dimensão)
        Console.WriteLine( "GetLowerBound" );
        int menorIndiceVector = vetor1.GetLowerBound(0);
        int menorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine( "Menor índice de valor1 {0}" , menorIndiceVector );

        // Public int GetUpperBound(dimensão)
        Console.WriteLine( "GetUpperBound" );
        int maiorIndiceVetor = vetor1.GetLowerBound(0);
        int maiorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine( "Maior índice de vetor1 {0}" , maiorIndiceVetor );

        //GetLongLength --> Pega o numero de elementos de uma dimensão de um array 
        //GetUpperBound --> Pega o maior elemento de uma dimensão de um array
        //GetLowerBound --> Pega o menor elemento de uma dimensão de um array
        
        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );

        // Public object GetValue(long índice)
        Console.WriteLine( "GetValue" );
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine( "Valor da posição 3 do vetor1: {0}" , valor0 );

        //GetValue --> Pega o valor de determinada posição / indice

        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );

        // Public static int IndexOf(array, valor)
        Console.WriteLine( "IndexOf" );
        int indice1 = Array.IndexOf( vetor1, 3); 
        Console.WriteLine( "Indice do primeiro valor 3: {0}" , indice1 ); 

        //IndexOf --> pega o indice do -primeiro- valor que for encontrado
        //LastIndexOf --> pega o indice do -ultimo- valor que for encontrado


        Console.WriteLine( "" );        

        Console.WriteLine( "--------------------------------------------" );

        Console.WriteLine( "" );
        
        Array.Reverse(vetor1);
        foreach(int x in vetor1){
            Console.WriteLine( x );
        }

        vetor2.SetValue( 99 , 0 );
        foreach(int x in vetor2){
            Console.WriteLine( x );
        }  

        Array.Sort(vetor1);

        //Reverse --> inverte a ordem dos elemtos de um array
        //SetValue --> ceta um valor em um determinada posiçao -> valor - posição 
        //Sort --> deixa em ordem os valores de um array
    }
}