
int? numero1, numero2, numero3, maiorNumero = null, menorNumero = null, intermediario = 0;
Boolean primeiraVez = true;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if(primeiraVez == true)
{   
    maiorNumero = numero1;
    menorNumero = numero1;
    intermediario = numero1;
    primeiraVez = false;
}

//MAIOR
if(numero1 > numero2 && numero1 > numero3)
{
    maiorNumero = numero1;
}
else
{
    if (numero2 > numero1 && numero2 > numero3)
    {
        maiorNumero = numero2;
    }

    if (numero3 > numero2 && numero3 > numero1)
    {
        maiorNumero = numero3;
    }

}

//MENOR
if (numero1 < numero2 && numero1 < numero3)
{
    menorNumero = numero1;
}
else
{
    if (numero2 < numero1 && numero2 < numero3)
    {
        menorNumero = numero2;
    }

    if (numero3 < numero2 && numero3 < numero1)
    {
        menorNumero = numero3;
    }

}

//INTERMEDIARIO
if (numero1 > numero2 && numero1 < numero3)
{
    intermediario = numero1;
}
else
{
    if (numero2 > numero1 && numero2 < numero3)
    {
        intermediario = numero2;
    }

    if (numero3 > numero2 && numero3 < numero1)
    {
        intermediario = numero3;
    }

}

Console.WriteLine("O Maior numero foi: " + maiorNumero);
Console.WriteLine("O Menor numero foi: " + menorNumero);
Console.WriteLine(maiorNumero + " " + intermediario + " " + menorNumero);