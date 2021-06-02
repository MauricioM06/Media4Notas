using System;

namespace Consulta
{   public class Program 
    {
        public static void Main(string [] args)
        {
			double Nota1;
			double Nota2;
			double Nota3;
			double Nota4;
			double Media;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Consulta de Média Final");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.WriteLine("Escreva suas notas de 0 a 10");
			Console.WriteLine();
			
			Console.Write("Primeira nota: ");
			Nota1 = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Segunda nota: ");
			Nota2 = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Terceira nota: ");
			Nota3 = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Quarta nota: ");
			Nota4 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			
			Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
			
			if (Nota1 > 10.0 || Nota2 > 10.0 || Nota3 > 10.0 || Nota4 > 10.0)
			{
				Console.WriteLine("Digite apenas números entre 0 e 10.");
			}
			else if (Nota1 < 0.0 || Nota2 < 0.0 || Nota3 < 0.0 || Nota4 < 0.0)
			{
				Console.WriteLine("Digite apenas números entre 0 e 10.");
			}
			else if (Media < 5)
			{
				Console.WriteLine($"Sua média final é de {Media:N1} \nSituação: Reprovado.");
			}
			else if (Media >= 5 && Media <= 5.9)
			{
				Console.WriteLine($"Sua média final é de {Media:N1} \nSituação: Em recuperação.");
			}
			else if (Media >= 6)
			{
				Console.WriteLine($"Sua média final é de {Media:N1} \nSituação: Aprovado.");
			}
        }
    }
}