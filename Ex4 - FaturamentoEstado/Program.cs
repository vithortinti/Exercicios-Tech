// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

// SP – R$67.836,43
// RJ – R$36.678,66
// MG – R$29.229,88
// ES – R$27.165,48
// Outros – R$19.849,53

// Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

public class Faturamento
{
    static void Main()
    {
        double valorMensalSP = 67836.43;
        double valorMensalRJ = 36678.66;
        double valorMensalMG = 29229.88;
        double valorMensalES = 27165.48;
        double valorMensalOutrosEstados = 19849.53;

        Console.Write("Digite o valor total do faturamento deste mês: ");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("São Paulo: " + (valor / valorMensalSP) * 100 + "%");
        Console.WriteLine("Rio de Janeiro: " + (valor / valorMensalRJ) * 100 + "%");
        Console.WriteLine("Minas Gerais: " + (valor / valorMensalMG) * 100 + "%");
        Console.WriteLine("Espírito Santo: " + (valor / valorMensalES) * 100 + "%");
        Console.WriteLine("Outros estados: " + (valor / valorMensalOutrosEstados) * 100 + "%");
    }
}