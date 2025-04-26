/*3. Cálculo de Fatorial com while
Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
while*/

using System;

namespace EX3{
    class Program{
        static void Main(string[] args){

            int i = 1, somador = 1;

            Console.Write("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int numFatorial = num;
            

            while (i < num)
            {
                
                somador *= numFatorial;
                numFatorial--;
                Console.WriteLine("\n" + numFatorial + " = " + somador);
                i++;
            }


        }
    }
}
