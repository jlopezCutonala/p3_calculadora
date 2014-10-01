using System;

namespace CalculadoraA
{
	class ClasePrincipal
	{
		public static void Main (string[] args)
		{
			Calculadora calculadoraSimple = new Calculadora();
			
			int resultadoSuma = calculadoraSimple.sumarDosNumeros(4, 5);
			Console.WriteLine("Resultado de la suma es de " + resultadoSuma);
			
			int resultadoResta = calculadoraSimple.restarDosNumeros(12, 5);
			Console.WriteLine("Resultado de la resta es de " + resultadoResta);
			
			int resultadoMultiplicacion = calculadoraSimple.multiplicarDosNumeros(12, 5);
			Console.WriteLine("Resultado de la multiplicacion es de " + resultadoMultiplicacion);
		}
	}
}

