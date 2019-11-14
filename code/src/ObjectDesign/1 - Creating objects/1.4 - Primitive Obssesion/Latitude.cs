using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.PrimitiveObssesion
{
    public class Latitude : ValueObject
    {
        private readonly float value;

        public Latitude(float value)
        {
            Ensure.Argument.Is(value >= -90 && value <= 90, "Latitude should be between -90 and 90");
            this.value = value;
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
