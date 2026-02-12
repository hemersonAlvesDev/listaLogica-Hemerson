// See https://aka.ms/new-console-template for more information

//Variáveis e Operações Básicas

#region 1. Calculadora de Média

Console.Write("Digite sua primeira nota com 2 casas decimais: ");
decimal nota01 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite sua segunda nota com 2 casas decimais: ");
decimal nota02 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite sua terceira nota com 2 casas decimais: ");
decimal nota03 = Convert.ToDecimal(Console.ReadLine());

decimal media = (nota01 + nota02 + nota03) / 3;

Console.WriteLine(media);

#endregion


#region 2. Conversor de idade

Console.Write("Digite sua Idade em Anos: ");
int anoCliente = Convert.ToInt16(Console.ReadLine());

int dias = anoCliente * 365;

Console.WriteLine(dias);

#endregion

#region 3. Troca de Valores

int A = 5;
int B = 8;
Console.WriteLine(A);
Console.WriteLine(B);

int temporario = A;

A = B;
B = temporario;

Console.WriteLine(A);
Console.WriteLine(B);

#endregion

//Nivel 2 Estruturas Condicionais (if, else if, else)
#region 1. verificador de maioridade

Console.Write("Digite sua Idade: ");
int idade = Convert.ToInt16(Console.ReadLine());

    if (idade >= 18)
{
    Console.WriteLine("Entrada Autorizada");
} else
{
    Console.WriteLine("Entrada Não Autorizada, Menor de Idade");
}


#endregion