using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunInss
{
    public class RunInss
    {
        ICalculadorInss calculadorInss;
        public RunInss(ICalculadorInss calculadorInss)
        {
            this.calculadorInss = calculadorInss;
        }

        public void Inss2011Test()
        {
            DateTime date = new DateTime(2011, 02, 10);
            decimal desconto = 0;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Testando Descontos Inss 2011");
            Console.WriteLine("Salario 1000.00");          
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1000.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 1106.91");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1106.91);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 1900.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1900.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 5000.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)5000.00);
            Console.WriteLine("Desconto: " + desconto);
            Console.WriteLine("");
        }

        public void Inss2012Test()
        {
            DateTime date = new DateTime(2012, 02, 10);
            decimal desconto = 0;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Testando Descontos Inss 2012");
            Console.WriteLine("Salario 1000.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1000.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 1150.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1150.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 1501.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)1501.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 3500.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)3500.00);
            Console.WriteLine("Desconto: " + desconto);

            Console.WriteLine("Salario 4500.00");
            desconto = calculadorInss.CalcularDesconto(date, (decimal)4500.00);
            Console.WriteLine("Desconto: " + desconto);
            Console.WriteLine("-----------------------------");

        }
    }
}
