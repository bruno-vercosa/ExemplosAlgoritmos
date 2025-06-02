int somaValores = 0, valor = -1;

while(valor != 0)
{
    Console.WriteLine("Digite um valor ou 0 para sair");
    valor = Convert.ToInt32(Console.ReadLine());

    somaValores += valor;
}

Console.WriteLine("A soma dos valores é: " + somaValores);