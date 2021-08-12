using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    // Product (Factory Method)
    public abstract class TabelaInss
    {
        private decimal teto;
        protected ICollection<FaixaInss> faixas { get; set; }

        public decimal getTeto()
        {
            return this.teto;
        }

        public void setTeto(decimal value)
        {
            this.teto = value;
        }

        public ICollection<FaixaInss> getFaixas()
        {
            return this.faixas;
        }

        public void setFaixas(ICollection<FaixaInss> value)
        {
            this.faixas = value;
        }

        public FaixaInss GetFaixaSalarial(decimal salario)
        {
            return faixas.Where(x => salario >= x.getSalarioMinFaixa()  && salario <= x.getSalarioMaxFaixa()).FirstOrDefault();
        }

        public abstract decimal CalcularDesconto(decimal salario);

    }
}
