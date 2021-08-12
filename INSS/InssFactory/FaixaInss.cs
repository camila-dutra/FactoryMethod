using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    public class FaixaInss
    {
        private decimal salarioMinFaixa;
        private decimal salarioMaxFaixa;
        private decimal aliquota;

        public FaixaInss(decimal salarioMinFaixa, decimal salarioMaxFaixa, decimal aliquota) 
        {
            this.salarioMinFaixa = salarioMinFaixa;
            this.salarioMaxFaixa = salarioMaxFaixa;
            this.aliquota = aliquota;
        }

        public decimal getSalarioMinFaixa()
        {
            return this.salarioMinFaixa;
        }

        public void setSalarioMinFaixa(decimal value)
        {
            this.salarioMinFaixa = value;
        }

        public decimal getSalarioMaxFaixa()
        {
            return this.salarioMaxFaixa;
        }

        public void setSalarioMaxFaixa(decimal value)
        {
            this.salarioMaxFaixa = value;
        }

        public decimal getAliquota()
        {
            return this.aliquota;
        }

        public void setAliquota(decimal value)
        {
            this.aliquota = value;
        }
    }
}
