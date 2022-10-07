namespace Pagamentos
{
    public abstract class Pagamento : IPagamento
    {
        public virtual void DataVencimento(DateOnly data)
        {
            var _data = DateOnly.FromDateTime(DateTime.Now);
            if (data < _data)
            {
                var diasVencidos = _data.DayNumber - data.DayNumber;
                Console.WriteLine($"O pagamento está em atraso. Vencimento: {data} ({diasVencidos} dias atrás).");
            }
            else
            {
                Console.WriteLine($"O pagamento ainda não venceu. Vencimento: {data}.");
            }
        }
        public virtual void ValorDocumento(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O pagamento não poderá ser efetuado! Valor inválido.");
                Environment.Exit(0);
            }
        }
    }

    public interface IPagamento
    {
        void DataVencimento(DateOnly data);
        void ValorDocumento(double valor);
    }
}
