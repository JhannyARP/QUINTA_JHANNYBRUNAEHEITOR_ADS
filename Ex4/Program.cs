/*4. Conversor de Temperaturas com Menu
Crie um menu com as opções:
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Use switch e while para manter o menu ativo até o usuário sair*/ 

using System;
using System.Globalization;

namespace EX4{
    class Program{
        static void Main(string[] args){

            int opcao;
            float grausCelcius, grausFahrenheit;
            float celciusParaFahrenheit, fahrenheitParaCelcius;
            

            do{
                
                Console.Write("\n1 - Celsius para Fahrenheit;\n2 - Fahrenheit para Celsius;\n3 - Sair");
                Console.Write("\nDigite a opcao: ");
                opcao = Convert.ToInt32(Console.ReadLine()); 

                switch (opcao)
                {
                    case 1: 
                        Console.Write("Quantos °C: ");
                        grausCelcius = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        celciusParaFahrenheit = (grausCelcius * 9 / 5) + 32;
                        Console.Write("Celsius para Fahrenheit: " + celciusParaFahrenheit + "°F\n");

                    break;             

                    case 2: 
                        Console.Write("Quantos °F: ");
                        grausFahrenheit = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        fahrenheitParaCelcius =  5f / 9 * (grausFahrenheit - 32);
                        Console.Write("Fahrenheit para Celsius: " + fahrenheitParaCelcius + "°C\n");

                    break;

                }


            }while (opcao != 3);










        }
    }
}

