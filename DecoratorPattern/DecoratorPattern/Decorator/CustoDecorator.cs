using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public abstract class CustoDecorator : ICusto
	{
		protected ICusto _custo;

		public CustoDecorator(ICusto custo)
		{
			_custo = custo;
		}

		//public string ComposicaoDoCusto => _custo.ComposicaoDoCusto;
		//public double Valor => _custo.Valor;

		public abstract string ComposicaoDoCusto { get; }
		public abstract double Valor { get; }
	}

}
