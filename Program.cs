//Faça um programa que leia um nome de usuario e a sua senha e não aceite a senha igual ao usuario, mostrando uma mensagem de erro e voltando a pedir as informações.

//Entrada
Console.WriteLine($"Insira seu nome de usuário: ");
string usuario = Console.ReadLine();
Console.WriteLine($"Insira sua senha: ");
string senha = Console.ReadLine();


//Processamento 
while (senha == usuario)
{
Console.WriteLine("Erro: a senha não pode ser igual ao nome de usuário. Tente novamente.");
Console.WriteLine($"Insira sua senha: ");
senha = Console.ReadLine();
}
Console.WriteLine($"Seu cadastro foi realizado com sucesso!");

//Saida

