using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Percentage : ValueObject
    {
        private int value;

        public Percentage(int value)
        {
            Ensure.Argument.Is(value >= 0 && value <= 100, "Percentage value must be between 0 and 100.");
        }

        public static Percentage FromScalar(int value)
        {
            return new Percentage(value);
        }

        public static implicit operator int(Percentage hue)
        {
            return hue.value;
        }

        public static explicit operator Percentage(int value)
        {
            return new Percentage(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }
    }
}
