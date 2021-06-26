using System;
using System.Collections.Generic;

namespace Exercicio_Desafio_Repetições
{
    class Program
    {
        static void Main(string[] args)
        {
            int ultimoElemento = 1;
            int penultimoElemento = 0;

            var sequenciaDeFibonacci = new List <int> { 1, 1 };

            while (sequenciaDeFibonacci.Count < 20)
            {
                var proximoElemento = sequenciaDeFibonacci [penultimoElemento] + sequenciaDeFibonacci [ultimoElemento];

                sequenciaDeFibonacci.Add(proximoElemento);

                ultimoElemento++;
                penultimoElemento++; 
            }

            Console.WriteLine("Os vinte primeros números da Sequência de Fibonacci são: ");

            foreach (var elemento in sequenciaDeFibonacci)
            {
                Console.WriteLine(elemento);
            }            
        }
    }
}
