using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public class CustoDaRefrigeracaoDecorator : CustoDecorator
	{
		public CustoDaRefrigeracaoDecorator(ICusto custo) : base(custo)
		{
		}

		public override string ComposicaoDoCusto => $@"{_custo.ComposicaoDoCusto}{Environment.NewLine}Custo da refrigeração";

		public override double Valor => _custo.Valor + CustoDaRefrigeracao();

		private double CustoDaRefrigeracao()
		{
			return 5.5;
		}
	}
}
