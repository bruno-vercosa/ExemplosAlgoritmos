string[] nomeJogadores = new string[11];
int[] golsJogadores = new int[11];
int indiceMaximoGols = -1;

for(int i = 0; i < 11; i++)
{
    Console.WriteLine("Digite o nome do jogador " + (i + 1) + ":");
    nomeJogadores[i] = Console.ReadLine();
    Console.WriteLine("Digite a quantidade de gols do jogador " 
        + nomeJogadores[i] + ":");
    golsJogadores[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < 11; i++)
{
    if(i == 0 || golsJogadores[indiceMaximoGols] < golsJogadores[i])
    {
        indiceMaximoGols = i;
    }
}
Console.WriteLine("O jogador que fez mais gols foi " + 
    nomeJogadores[indiceMaximoGols] +
    " com " + golsJogadores[indiceMaximoGols] + " gols.");