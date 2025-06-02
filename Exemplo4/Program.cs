decimal valorSacado, maiorValorSacado = 0, totalSacado = 0, mediaSaques;

for (int contador = 0; contador < 10; contador++)
{
    Console.WriteLine("Digite o valor do saque");
    valorSacado = Convert.ToDecimal(Console.ReadLine());

    totalSacado = totalSacado + valorSacado;

    if (valorSacado > maiorValorSacado)
    {
        maiorValorSacado = valorSacado;
    }
}
mediaSaques = totalSacado / 10;
Console.WriteLine("O total sacado foi: R$ " + totalSacado);
Console.WriteLine("O maior valor sacado foi: R$ " + maiorValorSacado);
Console.WriteLine("A media dos saques foi: R$ " + mediaSaques);
