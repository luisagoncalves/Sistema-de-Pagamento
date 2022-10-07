namespace Pagamentos
{
    public partial class Boleto : Pagamento
    {
        public override void DataVencimento(DateOnly data)
        {
            base.DataVencimento(data);
        }

        public override void ValorDocumento(double valor)
        {
            base.ValorDocumento(valor);
            Console.WriteLine($"O valor do boleto: R${valor:N2}.");
            GeracaoDeCodigoDeBarras();
        }
        private void GeracaoDeCodigoDeBarras()
        {
            Random numeros = new Random(13);

            for (int digitos = 0; digitos < 1; digitos++)
            {
                Console.WriteLine($"Código de barras: {numeros.NextInt64()}");
            }
        }

    }
}