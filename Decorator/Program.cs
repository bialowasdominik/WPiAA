namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPayment> payments = [new CardPayment(), new CashPayment(), new BankTransferPayment()];

            foreach (var payment in payments)
            {
                IPayment decoratedCardPayment = new SmsNotificationDecorator(
                new LoyaltyPointsDecorator(
                    new RedirectToHomepageDecorator(payment)
                    )
                );
                Shop shop = new(decoratedCardPayment);
                shop.MakePayment(150.00m);
            }
        }
    }
}
