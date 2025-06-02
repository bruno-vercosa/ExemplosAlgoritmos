int numero, soma = 0;

for(int cont = 0; cont < 5; cont++)
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    soma = soma + numero;
}

Console.WriteLine("A soma foi: " + soma);