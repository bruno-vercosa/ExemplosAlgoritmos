string continua = "s";
int velocidade, quantidadeMultado = 0;

while (continua.ToUpper() == "S")
{
    Console.WriteLine("Digite a velocidade do carro");
    velocidade = Convert.ToInt32(Console.ReadLine());

    if(velocidade > 120)
    {
        quantidadeMultado++;
    }

    Console.WriteLine("Deseja continuar? (s/n)");
    continua = Console.ReadLine();
}

Console.WriteLine("A quantidade de multas é: " + quantidadeMultado);