
decimal salarioBruto, salarioLiquido = 0, impostoRenda = 0, FGTS, descontoFGTS = 0.11M, sindicato, descontoSindicato = 0.03m, totalDescontos = 0;
int valorHora, horasTrabalhadas;

Console.WriteLine("Digite o valor da hora:");
valorHora = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas trabalhadas no mês:");
horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

salarioBruto = valorHora * horasTrabalhadas;
FGTS = salarioBruto * descontoFGTS;
sindicato = salarioBruto * descontoSindicato;

if(salarioBruto > 900.00m && salarioBruto <= 1500.00m)
{
    impostoRenda = salarioBruto * 0.05m;
}
else if(salarioBruto > 1500.00m && salarioBruto <= 2500.00m)
{
    impostoRenda = salarioBruto * 0.10m;
}
else if(salarioBruto > 2500.00m)
{
    impostoRenda = salarioBruto * 0.20m;
}

totalDescontos = impostoRenda + sindicato;
salarioLiquido = salarioBruto - totalDescontos;

Console.WriteLine("Salario Bruto: R$ " + salarioBruto);
Console.WriteLine("Imposto de Renda: R$ " + impostoRenda);
Console.WriteLine("Sindicato: R$ " + sindicato);
Console.WriteLine("FGTS: R$ " + FGTS);
Console.WriteLine("Total de Descontos: R$ " + totalDescontos);
Console.WriteLine("Salario Liquido: R$ " + salarioLiquido);
