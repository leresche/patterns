using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	public interface ICusto
	{
		string ComposicaoDoCusto { get; }
		double Valor { get; }
	}
}
