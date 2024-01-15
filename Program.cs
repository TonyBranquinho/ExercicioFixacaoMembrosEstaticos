using ExercicioFixacaoMembrosEstaticos;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotaçao do dolar? ");
            double Cotacao = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Quantos dolares voce vai comprar? ");
            double QuantidadeDolares = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine(ConversorDeMoedas.ValorEmReais(Cotacao, QuantidadeDolares).ToString("F2", CI));
        }
    }
}