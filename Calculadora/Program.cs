//Leia dois números, faça as quatro operações e mostre os resultados
float adicao, subtracao, multiplicacao, divisao, numero_1, numero_2;
int escolha = 1, operacao;
bool liberar = false;

do
{
    Console.Write("\nDigite um número: ");
    numero_1 = float.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    numero_2 = float.Parse(Console.ReadLine());

    Console.Write("Digite o número correspondente à operação desejada:\n");
    Console.Write("1 para Adição");
    Console.Write("2 para Subtração");
    Console.Write("3 para Multiplicação");
    Console.Write("4 para Divisão");
    operacao = int.Parse(Console.ReadLine());

    if (operacao == 1)
    {
        adicao = numero_1 + numero_2;
        Console.WriteLine($"\n{numero_1} + {numero_2} = {adicao} ");
    } 
    else if (operacao == 2)
    {
        subtracao = numero_1 - numero_2;
        Console.WriteLine($"\n{numero_1} - {numero_2} = {subtracao} ");
    }
    else if (operacao == 3)
    {
        multiplicacao = numero_1 * numero_2;
        Console.WriteLine($"\n{numero_1} * {numero_2} = {multiplicacao}");
    }
    else if (operacao == 4)
    {
        if (numero_1 == 0 || numero_2 == 0)
        {

            string mensagem = "Não é divisível por zero";
            Console.WriteLine($"\n{numero_1} / {numero_2} = {mensagem}");
        }
        else if (numero_2 < 0)
        {
            string mensagem = "Não é divisível por número negativo";
            Console.WriteLine($"\n{numero_1} / {numero_2} = {mensagem}");
        }
        else
        {
            divisao = numero_1 / numero_2;
            Console.WriteLine($"\n{numero_1} + {numero_2} = {adicao} ");
            Console.WriteLine($"\n{numero_1} - {numero_2} = {subtracao} ");
            Console.WriteLine($"\n{numero_1} * {numero_2} = {multiplicacao}");
            Console.WriteLine($"\n{numero_1} / {numero_2} = {divisao}");
        }
    }

    Console.WriteLine("\n---------------------------------------x---------------------------------------");
    

    liberar = false;

    while (liberar == false)
    {
        Console.WriteLine("\n---------------------------------------x---------------------------------------");
        Console.WriteLine("\nDeseja encerrar? Digite: ");
        Console.WriteLine("\n1 para SIM \n2 para NÃO");
        escolha = int.Parse(Console.ReadLine());
        
        if (escolha == 1 || escolha == 2) {
            
            if (escolha == 1)
            {
                Console.WriteLine("\nAguarde...\n");
                liberar = true;
            } else
            {
                Console.WriteLine("\nContinuando...\n");
                liberar = true;
            }
            
        } else
        {
            Console.WriteLine("\nOpção Inválida! \nTente novamente.");
        }
    }
} while (escolha != 1);

Console.WriteLine("\nPressione uma tecla para encerrar.");
Console.ReadKey();