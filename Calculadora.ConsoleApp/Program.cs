namespace Calculadora.ConsoleApp
{
    internal class Program
    {
         static void Main(string[] args)
        {
            string operacao = "";
            List<string> operacoesRealizadas = new List<string>();

            while (operacao != "S") {

                // Sanitização do input da operação
                while (true)
                {
                    Console.WriteLine("Calculadora Top 2023!");

                    Console.WriteLine("Digite a operação desejada:\n"
                        + "1. Soma entre dois sumeros.\n"
                        + "2. Subtração entre dois sumeros.\n"
                        + "3. Multiplicação entre dois sumeros.\n"
                        + "4. Divisão entre dois sumeros.\n"
                        + "5. Gerar a tabuada.\n"
                        + "6. Visualizar operações realizadas.\n"
                        + "S. Sair do programa.");

                    operacao = Console.ReadLine();

                    if (operacao == "S" || operacao == "s")
                    {
                        break;
                    }

                    if (operacao != "1"
                        && operacao != "2"
                        && operacao != "3"
                        && operacao != "4"
                        && operacao != "5"
                        && operacao != "6")
                    {
                        Console.WriteLine("Por favor digite uma operação valida.\n");
                        continue;
                    } else
                    {
                        break;
                    }
                    
                }

                // Parar o programa
                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                // Gerar tabuada
                if (operacao == "5")
                {
                    Console.Write("Digite o número para gerar a tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        int resto = i % 2;
                        if (resto == 0)
                            Console.BackgroundColor = ConsoleColor.Red;
                        else
                            Console.BackgroundColor = ConsoleColor.Black;

                        int resultadoMultiplicacao = tabuada * i;

                        Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
                    }
                    operacoesRealizadas.Add($"Gerar tabuada do numero: {tabuada}");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                // Visualizar operações realizadas
                else if (operacao == "6")
                {
                    foreach (string i in operacoesRealizadas)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    decimal resultado = 0;
                    decimal primeiroNumero = 0;
                    decimal segundoNumero = 0;

                    Console.Write("Por favor digite o primeiro numero: ");
                    primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Por favor digite o segundo numero: ");
                    segundoNumero = Convert.ToDecimal(Console.ReadLine());

                    switch (operacao)
                    {
                        // Soma
                        case "1":
                            resultado = primeiroNumero + segundoNumero; break;
                        // Subtração
                        case "2":
                            resultado = primeiroNumero - segundoNumero; break;
                        // Multiplicação
                        case "3":
                            resultado = primeiroNumero * segundoNumero; break;
                        // Divisão
                        case "4":
                            while (segundoNumero == 0)
                            {
                                Console.WriteLine("Segundo número não pode ser ZERO, tente novamente.");
                                Console.Write("Digite o segundo número: ");
                                segundoNumero = Convert.ToDecimal(Console.ReadLine());
                            }
                            resultado = primeiroNumero / segundoNumero;
                            break;
                    }

                    decimal resultadoFormatado = Math.Round(resultado, 2);

                    string sinalOperacao = "";

                    switch (operacao)
                    {
                        case "1": sinalOperacao = "+"; break;
                        case "2": sinalOperacao = "-"; break;
                        case "3": sinalOperacao = "*"; break;
                        case "4": sinalOperacao = "/"; break;

                        default:
                            break;
                    }

                    operacoesRealizadas.Add($"{primeiroNumero} {sinalOperacao} {segundoNumero} = {resultadoFormatado}");

                    Console.WriteLine($"O resultado da operação é: {operacoesRealizadas.Last()}");
                }
                Console.WriteLine("Digite qualquer tecla para continuar o programa.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}