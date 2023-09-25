using System.Runtime.CompilerServices;


int lado;
string linha = "";


Console.WriteLine("Digite o tamanho do lado:");
lado = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= lado; i++)
{
    linha += '*';
    
}

for (int i = 1; i <= lado; i++)
{
    Console.WriteLine(linha);

}