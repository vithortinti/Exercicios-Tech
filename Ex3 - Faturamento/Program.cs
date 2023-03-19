// 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
// • O menor valor de faturamento ocorrido em um dia do mês;
// • O maior valor de faturamento ocorrido em um dia do mês;
// • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

// IMPORTANTE:
// a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
// b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using Newtonsoft.Json;

public class Program
{
    static void Main()
    {
        var faturamentos = FaturamentoMensal(@"dados.json");
        faturamentos = IgnorarDiasComFaturamentoZerado(faturamentos);
        double mediaMensal = CalculaMediaMensal(faturamentos);
        
        Console.WriteLine("Menor valor de faturamento ocorrido no mês: R$" + faturamentos.Min(n => n.Valor));
        Console.WriteLine("Maior valor de faturamento ocorrido no mês: R$" + faturamentos.Max(n => n.Valor));
        Console.WriteLine("Quantidade de dias do mês em que o valor foi acima da média mensal: " + faturamentos.Where(
            n => n.Valor > mediaMensal
            ).Count());
    }

    static IEnumerable<Faturamento>? FaturamentoMensal(string dados)
    {
        string jsonString = File.ReadAllText(dados);
        List<Faturamento>? faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);
        return faturamentos;
    }

    static IEnumerable<Faturamento>? IgnorarDiasComFaturamentoZerado(IEnumerable<Faturamento> faturamentos)
    {
        return faturamentos.Where(faturamento => faturamento.Valor != 0);
    }

    static double CalculaMediaMensal(IEnumerable<Faturamento> faturamentos)
    {
        return faturamentos.Average(n => n.Valor);
    }
}

public class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}