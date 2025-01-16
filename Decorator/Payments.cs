namespace Decorator
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
    public class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Płatność kartą na kwotę {amount}.");
        }
    }

    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Płatność gotówką na kwotę {amount}.");
        }
    }

    public class BankTransferPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Płatność przelewem bankowym na kwotę {amount}.");
        }
    }
}
