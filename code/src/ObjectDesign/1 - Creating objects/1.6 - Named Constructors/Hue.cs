using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Hue : ValueObject
    {
        private double value;

        public Hue(double value)
        {
            Ensure.Argument.Is(value >= 0 && value <= 360, "Hue value must be between 0 and 360.");
            this.value = value;
        }

        public static Hue FromScalar(double value)
        {
            return new Hue(value);
        }

        public static implicit operator double(Hue hue)
        {
            return hue.value;
        }

        public static explicit operator Hue(int value)
        {
            return new Hue(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
