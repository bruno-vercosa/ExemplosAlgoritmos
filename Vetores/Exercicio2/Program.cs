string senha = "";
string[] senhaCriptografada = new string[6];

//Obriguei meu usuário a digitar uma senha com 6 caracteres
while (senha.Length != 6)
{
    Console.WriteLine("Digite a senha, utilizando vogais e " +
        "com 6 dígitos");
    senha = Console.ReadLine();
}

for(int i = 0; i < 6; i++)
{
    switch(senha[i])
    {
        case 'a':
            senhaCriptografada[i] = "z";
            break;
        case 'e':
            senhaCriptografada[i] = "3";
            break;
        case 'i':
            senhaCriptografada[i] = "j";
            break;
        case 'o':
            senhaCriptografada[i] = "9";
            break;
        case 'u':
            senhaCriptografada[i] = "$";
            break;
        default:
            Console.WriteLine("A senha deve conter apenas vogais");
            return;
    }
}

for (int j = 0; j < 6; j++)
{
    Console.Write(senhaCriptografada[j] + " ");
}
