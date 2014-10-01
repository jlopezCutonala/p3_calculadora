using System;
namespace CalculadoraA
{
	public class Calculadora
	{
		public Calculadora ()
		{
		}
		
		public int sumarDosNumeros(int sumandoA, int sumandoB){
			return sumandoA + sumandoB;
		}
		
		public int restarDosNumeros(int minuendo, int sustraendo){
			return minuendo - sustraendo;
		}
		
		public int multiplicarDosNumeros(int factorA, int factorB){
			return factorA * factorB;
		}
	}
}

