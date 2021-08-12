using INSS;
using INSS.Calculador;
using INSS.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace RunInss
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<ICalculadorInss, CalculadorInss>()
            .BuildServiceProvider();

            var calculadorInss = serviceProvider.GetService<ICalculadorInss>();

            RunInss runInss = new RunInss(calculadorInss);
            runInss.Inss2011Test();
            runInss.Inss2012Test();
        }
    }
}
