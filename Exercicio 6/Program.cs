
decimal valorCarro, valorDesconto = 0, desconto = 0.80m, valorFinal = 0.0m, valorParcela = 0.0m, valorJuros;
int quantidadeParcela = 0;
Boolean aVista = false;
string pagamentoAVista;

Console.WriteLine("Digite o valor do carro:");
valorCarro = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Deseja pagar a vista?(S/N)");
pagamentoAVista = Console.ReadLine();


if (pagamentoAVista == "S")
{
    aVista = true;
    valorDesconto = valorCarro * desconto;
    valorFinal = valorCarro - valorDesconto;
    aVista = false;
}
else {
    Console.WriteLine("Digite a quantidade de parcelas(6, 12, 18, 24,3 0, 36, 42, 48, 54 ou 60)");
    quantidadeParcela = Convert.ToInt32(Console.ReadLine());

    switch (quantidadeParcela)
    {
        case 6:
            valorJuros = valorCarro * 0.03m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 6;
            break;
        case 12:
            valorJuros = valorCarro * 0.06m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 12;
            break;
        case 18:
            valorJuros = valorCarro * 0.09m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 18;
            break;
        case 24:
            valorJuros = valorCarro * 0.12m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 24;
            break;
        case 30:
            valorJuros = valorCarro * 0.15m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 30;
            break;
        case 36:
            valorJuros = valorCarro * 0.18m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 36;
            break;
        case 42:
            valorJuros = valorCarro * 0.21m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 42;
            break;
        case 48:
            valorJuros = valorCarro * 0.24m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 48;
            break;
        case 54:
            valorJuros = valorCarro * 0.27m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 54;
            break;
        case 60:
            valorJuros = valorCarro * 0.30m;
            valorFinal = valorCarro + valorJuros;
            valorParcela = valorFinal / 60;
            break;
        default:
            Console.WriteLine("Valor inválido, digite uma opção de acordo");
            break;
    }
    
}

Console.WriteLine("O Valor final será: " + valorFinal);
Console.WriteLine("A quantidade de parcelas será: " + quantidadeParcela);
Console.WriteLine("O Valor da parcela será: " + valorParcela);