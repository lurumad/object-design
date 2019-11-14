using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.CompositeValues
{
    public class Currency : ValueObject
    {
        private readonly string code;

        public Currency(string code)
        {
            Ensure.Argument.NotNullOrEmpty(code, nameof(code));
            Ensure.Argument.Is(Currencies.Instance.IsValid(code), $"Invalid currency symbol ({code}).");
            this.code = code;
        }

        public static Currency FromCode(string code)
        {
            return new Currency(code);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return code;
        }

        public static implicit operator string(Currency currency)
        {
            return currency.code;
        }

        public static explicit operator Currency(string code)
        {
            return new Currency(code);
        }
    }
}