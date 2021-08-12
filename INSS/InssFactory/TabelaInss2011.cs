using INSS.InssFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    //Concrete Product (Factory Method)
    public class TabelaInss2011: TabelaInss
    {
        public TabelaInss2011()
        {
            base.faixas = new List<FaixaInss>();
            base.faixas.Add(new FaixaInss(0, (decimal)1106.90, 8));
            base.faixas.Add(new FaixaInss((decimal)1106.91, (decimal)1844.83, 9));
            base.faixas.Add(new FaixaInss((decimal)1844.84, (decimal)3689.66, 11));


            base.setTeto((decimal)405.86);
            base.setFaixas(faixas);
        }

        public override decimal CalcularDesconto(decimal salario)
        {
            FaixaInss faixaSalario = base.GetFaixaSalarial(salario);
            return (faixaSalario == null) ? base.getTeto() : salario * (faixaSalario.getAliquota() / 100);
        }
    }
}
