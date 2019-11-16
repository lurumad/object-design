using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Lightness : ValueObject
    {
        private double value;

        public Lightness(double value)
        {
            Ensure.Argument.Is(value >= 0 && value <= 100, "Lightness value must be between 0 and 100.");
            this.value = value;
        }

        public static Lightness FromScalar(double value)
        {
            return new Lightness(value);
        }

        public static implicit operator double(Lightness hue)
        {
            return hue.value;
        }

        public static explicit operator Lightness(double value)
        {
            return new Lightness(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
