using exercicios;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Salário bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        funcionario.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Daso do funcionário: {funcionario}");

        Console.WriteLine();
        Console.Write("Digite a porcentagem para aumentar o salario: ");
        funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

        Console.WriteLine();
        Console.WriteLine("Daso atualizados do funcionário: " + funcionario);
    }
}