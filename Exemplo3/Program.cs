string nome, matricula, ano;
int contador;

//DateTime.Now => Data e hora atual
//.Year => Ano de uma data
//.ToString() => Converte para string
ano = DateTime.Now.Year.ToString();

for(contador = 1; contador <= 15; contador++)
{
    Console.WriteLine("Digite o nome do aluno " + contador);
    nome = Console.ReadLine();

    matricula = ano + contador;
    Console.WriteLine(nome + " sua matricula é: " + matricula);
}
