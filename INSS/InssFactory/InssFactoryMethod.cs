using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.InssFactory
{
    //Creator (Factory Method)
    public abstract class InssFactoryMethod
    {
        //Factory Method
        public abstract TabelaInss CreateTabelaInss(DateTime date);

    }
}
