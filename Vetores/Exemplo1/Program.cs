string[] carros = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o modelo do carro " + (i + 1));
    carros[i] = Console.ReadLine();
}



for(int contador = 0; contador < 5; contador++)
{
    Console.WriteLine("Modelo do carro: " + carros[contador]);
}