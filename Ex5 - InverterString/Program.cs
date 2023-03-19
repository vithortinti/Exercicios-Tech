// 5) Escreva um programa que inverta os caracteres de um string.

// IMPORTANTE:
// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
// b) Evite usar funções prontas, como, por exemplo, reverse;

public class Program
{
    static void Main()
    {
        Console.Write("Digite algo para invertermos: ");
        string valor = Console.ReadLine();
        string result = string.Empty;

        for (int i = valor.Length - 1; i >= 0; i--)
        {
            result += valor[i];
        }

        Console.WriteLine(@"A frase\palavra '" + valor + "' invertida é: '" + result + "'");
    }
}