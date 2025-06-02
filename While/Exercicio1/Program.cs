int numero, soma = 0, contador = 0;

while(soma < 100)
{
    contador++;

    Console.WriteLine("Digite um número:");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}

Console.WriteLine("Foram necessários " + contador + " números para atingir 100");