using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    // Concrete Creator (Factory Method)
    public class InssFactory: InssFactoryMethod
    {
        public override TabelaInss CreateTabelaInss(DateTime date)
        {
            switch (date.Year)
            {
                case 2011: return new TabelaInss2011();
                case 2012: return new TabelaInss2012();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
