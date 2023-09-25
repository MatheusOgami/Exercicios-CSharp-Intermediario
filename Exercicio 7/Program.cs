// See https://aka.ms/new-console-template for more information

int numero, fator = 1;

Console.WriteLine("Digite um número para calcular seu fatorial:");
numero = Convert.ToInt32(Console.ReadLine());

if(numero == 0)
{
    Console.WriteLine("O Resultado é 1");
}
else
{
    for(int i = 1; i <= numero; i++)
    {
        fator *= i;
    }
}
Console.WriteLine("O Resultado é: "+ fator);