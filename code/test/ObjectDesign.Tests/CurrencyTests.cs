using FluentAssertions;
using ObjectDesign.CreatingObjects.CompositeValues;
using System;
using Xunit;

namespace ObjectDesign.Tests
{
    public class currency_should
    {
        [Fact]
        public void not_be_constructed_when_currency_symbol_is_empty()
        {
            Action sut = () => Currency.FromCode(string.Empty);
            sut.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void not_be_constructed_when_currency_symbol_is_not_valid()
        {
            Action sut = () => Currency.FromCode("AAA");
            sut.Should().Throw<ArgumentException>();
        }
    }
}
