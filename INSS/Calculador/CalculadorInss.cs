using INSS.Interfaces;
using INSS.InssFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Calculador
{
    public class CalculadorInss : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            InssFactory.InssFactory inssFactory = new InssFactory.InssFactory();

            //Liskov Substitution Principle
            TabelaInss tabelaInss = inssFactory.CreateTabelaInss(data);

            return tabelaInss.CalcularDesconto(salario);
        }

    }
}
