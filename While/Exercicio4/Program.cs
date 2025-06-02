int idade, contador = 0, somaIdades = 0, quantidadeMaior21 = 0;
string continuar = "s";

while(continuar.ToLower() == "s")
{
    contador++;
    Console.WriteLine("Digite a idade");
    idade = Convert.ToInt32(Console.ReadLine());
    somaIdades += idade;

    if (idade >= 21)
    {
        quantidadeMaior21++;
    }
    Console.WriteLine("Deseja informar outras idades? (s ou n)");
    continuar = Console.ReadLine();
}
Console.WriteLine("Foram digitadas " + contador + " idades");
Console.WriteLine("A média das idades foi: " + somaIdades / contador);
Console.WriteLine(quantidadeMaior21 + " pessoas tem mais de 21 anos");