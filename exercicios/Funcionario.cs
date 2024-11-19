using System;
using System.Globalization;

namespace exercicios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100.0);
        }

        public override string ToString() => Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        

    }
}
