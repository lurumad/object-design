using FluentAssertions;
using ObjectDesign.CreatingObjects.CompositeValues;
using System;
using Xunit;

namespace ObjectDesign.Tests
{
    public class money_should
    {
        [Fact]
        public void not_allow_to_be_constructed_when_amount_is_null()
        {
            Action money = () => new Money(null, new Currency("USD"));
            money.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void not_allow_to_be_constructed_when_currency_is_null()
        {
            Action money = () => new Money(Amount.FromScalar(1000), null);
            money.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void be_equal_to_other_money_of_the_same_amount_and_currency()
        {
            var money = Money.From(amount: 1000, code: "USD");
            money.Should().Be(Money.From(amount: 1000, code: "USD"));
        }

        [Fact]
        public void not_be_equal_to_other_money_of_different_currency()
        {
            var money = Money.From(amount: 1000, code: "USD");
            money.Should().NotBe(Money.From(amount: 1000, code: "EUR"));
        }
    }
}

