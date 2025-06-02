decimal[] salarios = new decimal[11];
int[] numerosCamisa = new int[11];
decimal totalSalarios = 0;

for(int i = 0; i < 11; i++)
{
    Console.WriteLine("Digite o salário do jogador " + (i + 1));
    salarios[i] = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o número da camisa do jogador " 
        + (i + 1));
    numerosCamisa[i] = Convert.ToInt32(Console.ReadLine());

    totalSalarios += salarios[i];
}

decimal mediaSalarios = totalSalarios / 11;

for(int i = 0; i < 11; i++)
{
    if (mediaSalarios < salarios[i])
    {
        Console.WriteLine("O jogador " + (i + 1) +
            " com o número da camisa " + numerosCamisa[i] +
            " tem um salário acima da média");
    }
}

