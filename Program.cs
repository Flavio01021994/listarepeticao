//11. Contagem de 1 a 20**

//Crie um programa que exiba os números de 1 a 20 na tela.
int digito = 1;
while (digito < 21)
{
    Console.WriteLine(digito);
    // incremento
    digito = digito + 1;
}

//2. Validação de senha**
//Peça ao usuário para inserir a senha "1234". Continue pedindo até que ele acerte.

int senha;

do
{
    Console.WriteLine("Informe a senha:");
    senha = int.Parse(Console.ReadLine());
} while (senha != 1234);

//3. Tabuada de um número**
//Peça ao usuário um número e exiba a tabuada dele de 1 a 10.

{
    // Solicita ao usuário que insira um número
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    // Exibe a tabuada de 1 a 10
    Console.WriteLine($"Tabuada de {numero}:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}