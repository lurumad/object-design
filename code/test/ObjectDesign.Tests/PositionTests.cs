using FluentAssertions;
using ObjectDesign.CreatingObjects.TestingConstructors;
using ObjectDesign.Properties;
using System;
using Xunit;

namespace ObjectDesign.Tests
{
    public class position_should
    {
        [Fact]
        public void not_allow_longitude_could_be_greater_than_180()
        {
            Action sut = () => new Position(Latitude.FromScalar(-100), Longitude.FromScalar(240));
            sut.Should().Throw<ArgumentException>().WithMessage(CoreStrings.InvalidLongitude);
        }

        [Fact]
        public void allow_to_calculate_the_distance_in_kilometers_from_granada_to_madrid()
        {
            var granada = new Position((Latitude)37.1773f, (Longitude)(-3.5985f));
            var madrid = new Position((Latitude)40.4168f, (Longitude)(-3.70379f));
            var distance = granada.DistanceInKilometersTo(madrid);
            distance.Should().Be(360.727539f);
        }
    }
}
