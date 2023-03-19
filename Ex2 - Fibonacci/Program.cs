// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
// (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a 
// sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

// IMPORTANTE:
// Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

public class Program
{
    static void Main()
    {
        Console.Write("Digite um número e verifique se ele é pertencente a sequência de Fibonacci: ");
        uint num = uint.Parse(Console.ReadLine());

        bool exists = ValorExisteEmFibonacci(num);
        
        if (exists)
            Console.WriteLine("O número " + num + " existe na sequência de Fibonnaci");
        else
            Console.WriteLine("O número " + num + " não existe na sequência de Fibonnaci");
    }

    public static bool ValorExisteEmFibonacci(uint num)
    {
        if (num == 0) return true;

        uint anterior = 0;
        uint atual = 1;
        uint resultado = 0;

        while (resultado < num)
        {
            resultado = anterior;
            anterior = anterior + atual;
            atual = resultado;
            
            if (num == resultado)
                return true;
        }

        return false;
    }
}