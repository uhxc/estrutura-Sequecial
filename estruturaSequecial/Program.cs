namespace estruturaSequecial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("selecione qual opção deseja");
            Console.WriteLine("1 - somar numeros inteiros");
            Console.WriteLine("2 - calcular o radio de um circulo");
            Console.WriteLine("3 - calcular a diferenca entre 4 numeros");
            int caso = int.Parse(Console.ReadLine());
            object soma = 0.0;

            if (caso == 1) {    
                Console.WriteLine("digite um numero inteiro:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("digite outro numero inteiro:");
                int num2 = int.Parse(Console.ReadLine());

                soma = num1 + num2;

                Console.WriteLine($"a soma de {num1} + {num2} numeros é {soma}");
            }
            else if (caso == 2) {
                Console.WriteLine("digite o raio do circulo");
                double r = double.Parse(Console.ReadLine());

                soma = 3.14159 * r * r;

                Console.WriteLine($"a= {soma:F4}");
            }
            else if (caso == 3) {
                Console.WriteLine("digite o primeiro numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo numero");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o terceiro numero");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o quarto numero");
                int d = int.Parse(Console.ReadLine());
                soma = (a * b) - (c * d);

                Console.WriteLine(soma);
            }

        }
    }
}