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

