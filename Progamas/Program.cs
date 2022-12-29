//metodo:
using System;

namespace ProjetoCalc;

class Program
{
  static void Main(string[]args)
  {
    //calculadora com metodos

    while(true){
   System.Console.WriteLine("Calculadora");
   System.Console.WriteLine("Digite o primeiro numero: ");
   int num1 = int.Parse(Console.ReadLine());
   System.Console.WriteLine("=======================");
   System.Console.WriteLine("Digite o segund numero: ");
   int num2 = int.Parse(Console.ReadLine());
   System.Console.WriteLine("=======================");
   System.Console.WriteLine("Cada operacao: 1-Soma, 2-Subtracao, 3-Divisao, 4-Multiplicacao, 5-Exponeciação");
   int operacao = int.Parse(Console.ReadLine());
   System.Console.WriteLine("=======================");
   if(operacao == 1)
   {
      Calculadora.Soma(num1,num2);  
   }
  if(operacao == 2)
   {
      Calculadora.Subtracao(num1,num2);
   }
   if(operacao == 3)
   {
      Calculadora.Divisao(num1,num2);
   }
   if(operacao == 4)
   {
      Calculadora.Multiplicacao(num1,num2);
   }
   if(operacao == 5)
   {
    Calculadora.Exponeciacao(num1,num2);
   }
    else 
    {
      break;
    }
  }
  }
}
//fim...