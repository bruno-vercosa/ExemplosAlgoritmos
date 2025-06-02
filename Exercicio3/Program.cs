decimal altura;
int quantidadeMaior1_90 = 0;

for(int i = 0; i < 12; i++)
{
    Console.WriteLine("Digite a altura");
    altura = Convert.ToDecimal(Console.ReadLine());

    if(altura > 1.90M)
    {
        quantidadeMaior1_90++;
    }
}

Console.WriteLine("Foram encontrados " + quantidadeMaior1_90 +
    " atletas com mais de 1.90m");
