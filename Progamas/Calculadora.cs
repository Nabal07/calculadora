using System;

namespace ProjetoCalc
{
    public class Calculadora
    {
        //Soma 
        public static void Soma (int num1, int num2)
        {
            int resultado = num1 + num2;
            System.Console.WriteLine($"A soma de {num1} + {num2} = {resultado}");
        }
        //Subtracao
        public static void Subtracao (int num1, int num2)
        {
            int resultado = num1 - num2;
            System.Console.WriteLine($"A subtracao de {num1} - {num2} = {resultado}");
        }
       //Divisao
        public static void Divisao (int num1, int num2)
        {
            int resultado = num1 / num2;
            System.Console.WriteLine($"A divisao de {num1} / {num2} = {resultado}");
        }
       //Multiplicacao
        public static void Multiplicacao (int num1, int num2)
        {
            int resultado = num1 * num2;
            System.Console.WriteLine($"A multiplicacao de {num1} * {num2} = {resultado}");
        }
        //Exponeceacao
        public static void Exponeciacao (int num1, int num2) =>
        Console.WriteLine($"A exponeciacao de {num1} ** {num2} = {(int)Math.Pow(num1,num2)}");
        } 
    }
