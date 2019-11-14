using ObjectDesign.Properties;
using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.TestingConstructors
{
    public class Longitude : ValueObject
    {
        private readonly float value;

        public Longitude(float value)
        {
            Ensure.Argument.Is(value >= -180 && value <= 180, CoreStrings.InvalidLongitude);
            this.value = value;
        }

        public static Longitude FromScalar(float value)
        {
            return new Longitude(value);
        }

        public static implicit operator float(Longitude longitude)
        {
            return longitude.value;
        }

        public static explicit operator Longitude(float value)
        {
            return new Longitude(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
