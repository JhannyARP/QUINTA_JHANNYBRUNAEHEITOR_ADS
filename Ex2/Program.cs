
/*2. Tabuada Completa com Laço
Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
utilizando um for.*/

using System;
using System.Globalization;


namespace EX1{

    class Program{

        static void Main(string[] args){

            int calculo;

            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                calculo = num * i;
                Console.Write("\n" + i + " x " + num + " = " + calculo);
            }


        }
    }
}
