using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Saturation : ValueObject
    {
        private double value;

        public Saturation(double value)
        {
            Ensure.Argument.Is(value >= 0 && value <= 100, "Saturation value must be between 0 and 100.");
            this.value = value;
        }

        public static Saturation FromScalar(double value)
        {
            return new Saturation(value);
        }

        public static implicit operator double(Saturation hue)
        {
            return hue.value;
        }

        public static explicit operator Saturation(double value)
        {
            return new Saturation(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
