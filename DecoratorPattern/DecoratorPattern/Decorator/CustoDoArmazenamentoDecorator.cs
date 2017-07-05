using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public class CustoDoArmazenamentoDecorator : CustoDecorator
	{
		public CustoDoArmazenamentoDecorator(ICusto custo) : base(custo)
		{
		}

		public override string ComposicaoDoCusto => $@"{_custo.ComposicaoDoCusto}{Environment.NewLine}Custo do armazenamento";

		public override double Valor => _custo.Valor + 3.2;
	}
}
