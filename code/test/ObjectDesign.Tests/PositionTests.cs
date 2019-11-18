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
            Action position = () => new Position(Latitude.FromScalar(-100), Longitude.FromScalar(240));
            position.Should().Throw<ArgumentException>().WithMessage(CoreStrings.InvalidLatitude);
        }

        [Fact]
        public void be_equal_to_another_position_with_the_same_latitude_and_longitude()
        {
            var positionOne = new Position((Latitude)37.1773f, (Longitude)(-3.5985f));
            var positionTwo = new Position((Latitude)37.1773f, (Longitude)(-3.5985f));
            positionOne.Should().Be(positionTwo);
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
