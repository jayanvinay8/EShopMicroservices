namespace Ordering.Domain.ValueObjects
{
    public record Payment
    {
        protected Payment() { }

        private Payment(string cardName,string cardNumber,string expiration,string cvv,int paymentMethod)
        {
            CardNumber = cardNumber;
            Expiration = expiration;
            CardName = cardName;
            CVV = cvv;
            PaymentMethod = paymentMethod;
        }
        public string? CardName { get;  } = default!;
        public string CardNumber { get;  }=default!;
        public string Expiration { get;  } = default!;
        public string CVV { get;  } = default!;
        public int PaymentMethod { get; } = default!;

        public static Payment Of(string cardName, string cardNumber, string expiration, string cvv, int paymentMethod)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace (cardName);
            ArgumentException.ThrowIfNullOrWhiteSpace (cardNumber);
            ArgumentException.ThrowIfNullOrWhiteSpace (expiration);
            ArgumentException.ThrowIfNullOrWhiteSpace (cvv);
            ArgumentOutOfRangeException.ThrowIfNotEqual(cvv.Length, 3);

            return new Payment(cardName, cardNumber, expiration, cvv, paymentMethod);
        }
    }
}
