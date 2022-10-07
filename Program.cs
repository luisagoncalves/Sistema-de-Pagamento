
namespace Pagamentos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var data = new DateOnly(2022, 04, 05);
            
            Boleto b1 = new Boleto();
            b1.DataVencimento(data);
            b1.ValorDocumento(1500);
        }
    }
}

