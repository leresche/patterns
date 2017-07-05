using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public class CustoDaAquisicaoDecorator : CustoDecorator
	{
		public CustoDaAquisicaoDecorator(ICusto custo)
			: base(custo)
		{
		}

		public override string ComposicaoDoCusto => $@"{_custo.ComposicaoDoCusto}{Environment.NewLine}Custo da aquisição";

		public override double Valor => _custo.Valor + CalculaCustoDaAquisicao();

		private double CalculaCustoDaAquisicao() => 4.6;
	}
}
