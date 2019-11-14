using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.CompositeValues
{
    public class Money : ValueObject
    {
        private readonly Amount amount;
        private readonly Currency currency;

        public Money(Amount amount, Currency currency)
        {
            Ensure.Argument.NotNull(amount, nameof(amount));
            Ensure.Argument.NotNull(currency, nameof(currency));
            this.amount = amount;
            this.currency = currency;
        }

        public static Money From(decimal amount, string code)
        {
            return new Money(Amount.FromScalar(amount), Currency.FromCode(code));
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return amount;
            yield return currency;
        }
    }
}
