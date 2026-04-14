using SistemaPagamentos.Models;
using SistemaPagamentos.UI;

string opcao = "";

while (opcao != "3")
{
    Menu.ExibirMenu();
    opcao = Console.ReadLine() ?? "";

    if (opcao == "1")
    {
        Console.Write("Informe o valor do pagamento: ");
        string entradaValor = Console.ReadLine() ?? "0";

        entradaValor = entradaValor.Replace(".", ",");

        if (!decimal.TryParse(entradaValor, System.Globalization.NumberStyles.Any,
            new System.Globalization.CultureInfo("pt-BR"), out decimal valor))
        {
            Console.WriteLine("Valor invalido. Tente novamente.");
            continue;
        }

        Console.Write("Informe o numero do cartao: ");
        string numeroCartao = Console.ReadLine() ?? "";

        PagamentoCartao pagamentoCartao = new PagamentoCartao(valor, numeroCartao);
        Console.WriteLine(pagamentoCartao.ProcessarPagamento());
    }
    else if (opcao == "2")
    {
        Console.Write("Informe o valor do pagamento: ");
        string entradaValor = Console.ReadLine() ?? "0";

        entradaValor = entradaValor.Replace(".", ",");

        if (!decimal.TryParse(entradaValor, System.Globalization.NumberStyles.Any,
            new System.Globalization.CultureInfo("pt-BR"), out decimal valor))
        {
            Console.WriteLine("Valor invalido. Tente novamente.");
            continue;
        }

        Console.Write("Informe o codigo de barras: ");
        string codigoBarras = Console.ReadLine() ?? "";

        PagamentoBoleto pagamentoBoleto = new PagamentoBoleto(valor, codigoBarras);
        Console.WriteLine(pagamentoBoleto.ProcessarPagamento());
    }
    else if (opcao == "3")
    {
        Console.WriteLine("Encerrando o sistema. Ate logo!");
    }
    else
    {
        Console.WriteLine("Opcao invalida. Tente novamente.");
    }
}
