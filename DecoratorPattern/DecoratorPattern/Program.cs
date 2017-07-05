using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ICusto custo = new CustoInicial();
			Console.WriteLine(custo.ComposicaoDoCusto);
			Console.WriteLine(custo.Valor);

			custo = new CustoDaAquisicaoDecorator(custo);
			Console.WriteLine(custo.ComposicaoDoCusto);
			Console.WriteLine(custo.Valor);

			custo = new CustoDaValidadeDecorator(custo);
			Console.WriteLine(custo.ComposicaoDoCusto);
			Console.WriteLine(custo.Valor);
			
			custo = new CustoDaRefrigeracaoDecorator(custo);
			Console.WriteLine(custo.ComposicaoDoCusto);
			Console.WriteLine(custo.Valor);

			custo = new CustoDoArmazenamentoDecorator(custo);
			Console.WriteLine(custo.ComposicaoDoCusto);
			Console.WriteLine(custo.Valor);

			Console.Read();
		}
	}
}
