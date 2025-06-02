decimal[] cartela = new decimal[10];

for(int contador = 0; contador < 10; contador++)
{
    Console.WriteLine("Qual o valor da sua conta?");
    cartela[contador] = Convert.ToDecimal(Console.ReadLine());

    if(contador == 9)
    {
        Console.WriteLine("Hoje o seu almoço é uma cortesia da casa, " +
            "parabéns!");

        for(int i = 0; i < 10; i++)
        {
            cartela[i] = 0;
        }
        contador = -1;
    }
}

