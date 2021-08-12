using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    //Concrete Product (Factory Method)
    public class TabelaInss2012 : TabelaInss
    {
        public TabelaInss2012()
        {
            base.faixas = new List<FaixaInss>();
            base.faixas.Add(new FaixaInss(0, (decimal)1000.00, 7));
            base.faixas.Add(new FaixaInss((decimal)1000.01, (decimal)1500.00, 8));
            base.faixas.Add(new FaixaInss((decimal)1500.01, (decimal)3000.00, 9));
            base.faixas.Add(new FaixaInss((decimal)3000.01, (decimal)4000.00, 11));

            base.setTeto((decimal)500.00);
            base.setFaixas(faixas);
        }
    }
}
