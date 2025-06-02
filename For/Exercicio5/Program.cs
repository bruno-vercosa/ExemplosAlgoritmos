int chuteBolinhas;

for(int contador = 0; contador < 5; contador++)
{
    Console.WriteLine("Quantas bolinhas tem no pote?");
    chuteBolinhas = Convert.ToInt32(Console.ReadLine());

    if(chuteBolinhas == 82)
    {
        Console.WriteLine("Parabéns, você acertou!");
        break;
    }
    else if(chuteBolinhas < 82)
    {
        Console.WriteLine("Você errou, existem mais bolinhas do que o chute");
    }
    else if(chuteBolinhas > 82)
    {
        Console.WriteLine("Você errou, existem menos bolinhas do que o chute");
    }
}