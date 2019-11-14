using ObjectDesign.Properties;
using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.TestingConstructors
{
    public class Latitude : ValueObject
    {
        private readonly float value;

        public Latitude(float value)
        {
            Ensure.Argument.Is(value >= -90 && value <= 90, CoreStrings.InvalidLatitude);
            this.value = value;
        }

        public static Latitude FromScalar(float value)
        {
            return new Latitude(value);
        }

        public static implicit operator float(Latitude latitude)
        {
            return latitude.value;
        }

        public static explicit operator Latitude(float value)
        {
            return new Latitude(value);
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
