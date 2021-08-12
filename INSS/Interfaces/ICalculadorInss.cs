using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Interfaces
{
    public interface ICalculadorInss
	{
		/// <summary>
		/// Deve retornar o deconto do INSS aplicado ao salário, na determinada data.
		/// </summary>
		 decimal CalcularDesconto(DateTime data, decimal salario);
    }
}
