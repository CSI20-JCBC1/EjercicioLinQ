using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) { 

       List<int> listaEnteros = new List<int>();
        for (int i =1; i < 101; i++)
        {
            listaEnteros.Add(i);
            
        }

       var numeros = from i in listaEnteros where (i % 7 ==0)
              orderby i descending
              select i.ToString();

        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine();

        LinQuery(listaEnteros);
    }

    public static void LinQuery(List<int> listaEnteros)
    {

        var numeros = listaEnteros.Where(a => a % 7 == 0);
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }

    }
}


