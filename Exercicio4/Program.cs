int numero;
decimal valor, soma = 0.0m;

Console.WriteLine("Digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

for(decimal i = 1; i <= numero; i++)
{
    valor = 1 / i;
    soma += valor;
}
Console.WriteLine(soma);
