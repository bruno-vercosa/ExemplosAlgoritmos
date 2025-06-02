int numero, quantidadeMaior50 = 0;

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero > 50)
    {
        quantidadeMaior50++;
    }
}

Console.WriteLine("Foram encontrados " +  quantidadeMaior50 + 
    " números maiores que 50");