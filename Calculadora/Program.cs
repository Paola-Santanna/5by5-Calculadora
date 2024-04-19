//Leia dois números, faça as quatro operações e mostre os resultados
float adicao, subtracao, multiplicacao, divisao, numero_1, numero_2, aux_1, aux_2;
int escolha = 1, operacao, aux_operacao;
bool liberar_1 = false, liberar_2 = false;

Console.WriteLine("--- Calculadora ---\n");

do
{
    Console.Write("Digite um número: ");
    numero_1 = float.Parse(Console.ReadLine());
    aux_1 = numero_1;
    Console.Write("Digite outro número: ");
    numero_2 = float.Parse(Console.ReadLine());
    aux_2 = numero_2;

    Console.WriteLine("\nDigite o número correspondente à operação desejada:\n");
    Console.WriteLine("1 para Adição");
    Console.WriteLine("2 para Subtração");
    Console.WriteLine("3 para Multiplicação");
    Console.WriteLine("4 para Divisão");
    Console.Write("Sua resposta: ");
    operacao = int.Parse(Console.ReadLine());
    aux_operacao = operacao;

    do
    {
        if (aux_operacao == 1)
        {
            adicao = aux_1 + aux_2;
            Console.WriteLine($"\n{aux_1} + {aux_2} = {adicao} ");
            liberar_1 = true;
        }
        else if (aux_operacao == 2)
        {
            subtracao = aux_1 - aux_2;
            Console.WriteLine($"\n{aux_1} - {aux_2} = {subtracao} ");
            liberar_1 = true;
        }
        else if (aux_operacao == 3)
        {
            multiplicacao = aux_1 * aux_2;
            Console.WriteLine($"\n{aux_1} * {aux_2} = {multiplicacao}");
            liberar_1 = true;
        }
        else if (aux_operacao == 4)
        {
            if (aux_1 == 0 || aux_2 == 0)
            {

                string mensagem = "Não é divisível por zero";
                Console.WriteLine($"\n{aux_1} / {aux_2} = {mensagem}");
            }
            else
            {
                divisao = aux_1 / aux_2;
                Console.WriteLine($"\n{aux_1} / {aux_2} = {divisao}");
            }
            liberar_1 = true;
        }
        else
        {
            Console.WriteLine("\nOpção Inválida\n");
            liberar_1 = false;
        }

        liberar_2 = false;

        while (liberar_2 == false)
        {
            Console.WriteLine("\n-------------------x-------------------");
            Console.WriteLine("Deseja encerrar? Digite: ");
            Console.WriteLine("\n1 para SIM \n2 para NÃO");
            Console.Write("Sua escolha: ");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1 || escolha == 2)
            {

                if (escolha == 1)
                {
                    Console.WriteLine("\nAguarde...");
                    liberar_2 = true;
                    Console.WriteLine("-------------------x-------------------");
                }
                else
                {
                    Console.WriteLine("\nContinuando...");
                    liberar_2 = true;
                    Console.WriteLine("-------------------x-------------------\n");
                }

            }
            else
            {
                Console.WriteLine("\nOpção Inválida! \nTente novamente.");
            }
        }
    } while (liberar_2 != true);

} while (escolha != 1);

Console.WriteLine("\nPressione uma tecla para encerrar.");
Console.ReadKey();