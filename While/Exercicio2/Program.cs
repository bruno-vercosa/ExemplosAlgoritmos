string nomePiloto, continuar = "s", pilotoMaisRapido = "", pilotoMaisLento = "";
decimal velocidadeVolta, tempoMaisRapido = 0, tempoMaisLento = 0, 
    somaTempos = 0; ;
int quantidadePilotos = 0;

while(continuar.ToUpper() == "S")
{
    quantidadePilotos++;

    Console.WriteLine("Digite o nome do piloto:");
    nomePiloto = Console.ReadLine();
    Console.WriteLine("Digite a velocidade do piloto");
    velocidadeVolta = Convert.ToDecimal(Console.ReadLine());

    //Testando o mais lento
    if(quantidadePilotos == 1 || tempoMaisLento < velocidadeVolta)
    {
        pilotoMaisLento = nomePiloto;
        tempoMaisLento = velocidadeVolta;
    }
    
    if(quantidadePilotos == 1 || tempoMaisRapido > velocidadeVolta)
    {
        pilotoMaisRapido = nomePiloto;
        tempoMaisRapido = velocidadeVolta;
    }

    somaTempos += velocidadeVolta;

    Console.WriteLine("Deseja informar outros tempos? (s ou n)");
    continuar = Console.ReadLine();
}

Console.WriteLine("O piloto: " + pilotoMaisRapido + 
    " foi o mais rápido, tempo: " + tempoMaisRapido);
Console.WriteLine("O piloto: " + pilotoMaisLento +
    " foi o mais lento, tempo: " + tempoMaisLento);
Console.WriteLine("A média de tempo dos pilotos foi: " + 
    (somaTempos / quantidadePilotos));