using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public class CustoDaValidadeDecorator : CustoDecorator
	{
		public CustoDaValidadeDecorator(ICusto custo) : base(custo)
		{
		}

		public override string ComposicaoDoCusto => $@"{_custo.ComposicaoDoCusto}{Environment.NewLine}Custo da validade";

		public override double Valor => _custo.Valor + CustoDaValidade();

		private double CustoDaValidade()
		{
			return 8.5;
		}
	}
}
