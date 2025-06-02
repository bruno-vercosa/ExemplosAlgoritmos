decimal nota, soma = 0, maiorNota = 0, menorNota = 0;

for(int contador = 0; contador < 10; contador++)
{
    Console.WriteLine("Digite a nota do aluno " + (contador + 1));
    nota = Convert.ToDecimal(Console.ReadLine());

    soma = soma + nota;

    if(contador == 0 || nota < menorNota)
    {
        menorNota = nota;
    }

    if(contador == 0 || nota > maiorNota)
    {
        maiorNota = nota;
    }
}

Console.WriteLine("A média das notas foi: " + (soma / 10));
Console.WriteLine("A maior nota foi: " + maiorNota);
Console.WriteLine("A menor nota foi: " + menorNota);