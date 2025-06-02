int numero, somatorio = 0, menorValorDigitado = 0, quantidade = 0, 
    quantidadePares = 0;
string continuar = "s";

while(continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    somatorio += numero;
    quantidade++;

    if(quantidade == 1 || numero < menorValorDigitado)
    {
        menorValorDigitado = numero;
    }

    if(numero % 2 == 0)
    {
        quantidadePares++;
    }

    Console.WriteLine("Deseja continuar? (s ou n)");
    continuar = Console.ReadLine();
}

Console.WriteLine("Somatório: " + somatorio);
Console.WriteLine("Menor valor digitado: " + menorValorDigitado);
Console.WriteLine("Média: " + somatorio / quantidade);
Console.WriteLine("Quantidade de pares: " + quantidadePares);