namespace SistemaPagamentos.Models
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras { get; set; }

        public PagamentoBoleto(decimal valor, string codigoBarras) : base(valor)
        {
            CodigoBarras = codigoBarras;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor:F2} via Boleto " +
                   $"(Cod Barra: {CodigoBarras}) " +
                   $"na data {DataPagamento:dd/MM/yyyy}.";
        }
    }
}
