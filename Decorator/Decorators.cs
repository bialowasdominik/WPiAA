namespace Decorator
{
    public abstract class PaymentDecorator : IPayment
    {
        protected readonly IPayment _decoratedPayment;

        protected PaymentDecorator(IPayment decoratedPayment)
        {
            _decoratedPayment = decoratedPayment;
        }

        public virtual void Pay(decimal amount)
        {
            _decoratedPayment.Pay(amount);
        }
    }

    public class SmsNotificationDecorator : PaymentDecorator
    {
        public SmsNotificationDecorator(IPayment decoratedPayment) : base(decoratedPayment) { }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            if (_decoratedPayment is CardPayment)
            {
                Console.WriteLine("Wysyłanie powiadomienia SMS o dokonanej płatności.");
            }
        }
    }

    public class LoyaltyPointsDecorator : PaymentDecorator
    {
        public LoyaltyPointsDecorator(IPayment decoratedPayment) : base(decoratedPayment) { }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            if (_decoratedPayment is CardPayment)
            {
                Console.WriteLine("Dodano punkty lojalnościowe do konta użytkownika.");
            }
        }
    }

    public class RedirectToHomepageDecorator : PaymentDecorator
    {
        public RedirectToHomepageDecorator(IPayment decoratedPayment) : base(decoratedPayment) { }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            if (_decoratedPayment is CardPayment)
            {
                Console.WriteLine("Przekierowanie na stronę główną sklepu.");
            }
        }
    }
}
