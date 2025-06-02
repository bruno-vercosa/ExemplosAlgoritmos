int chuteBolinhas = 0, contador = 0;

while(chuteBolinhas != 82)
{
    contador++;

    Console.WriteLine("Quantas bolinhas tem no pote?");
    chuteBolinhas = Convert.ToInt32(Console.ReadLine());

    if (chuteBolinhas == 82)
    {
        Console.WriteLine("Parabéns, você acertou!");
        break;
    }

    else if (chuteBolinhas < 82)
    {
        Console.WriteLine("Você errou, existem mais bolinhas do que o chute");
    }
    else if (chuteBolinhas > 82)
    {
        Console.WriteLine("Você errou, existem menos bolinhas do que o chute");
    }
}
Console.WriteLine("Foram necessários " + contador + 
    " tentativas para o acerto");