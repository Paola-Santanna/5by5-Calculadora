//Leia dois números, faça as quatro operações e mostre os resultados
float adicao, subtracao, multiplicacao, divisao;
float numero_1, numero_2;

Console.Write("\nDigite um número: ");
numero_1 = float.Parse(Console.ReadLine());
Console.Write("Digite outro número: ");
numero_2 = float.Parse(Console.ReadLine());

adicao = numero_1 + numero_2;
subtracao = numero_1 - numero_2;
multiplicacao = numero_1 * numero_2;
divisao = numero_1 / numero_2;

Console.WriteLine($"\nOs resultados são: \n{numero_1} + {numero_2} = {adicao} \n{numero_1} - {numero_2} = {subtracao} \n{numero_1} * {numero_2} = {multiplicacao} \n{numero_1} / {numero_2} = {divisao}");

Console.ReadKey();