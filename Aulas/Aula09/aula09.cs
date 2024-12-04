using System;

class Aula09
{
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main()
    {
        DiasSemana ds = (DiasSemana)3; //Quarta
        // int ds = (int)DiasSemana.Sexta; Pega o valor do indice de Sexta

        Console.WriteLine(ds);
    }
}