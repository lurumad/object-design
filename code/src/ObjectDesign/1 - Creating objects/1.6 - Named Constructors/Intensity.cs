using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Intensity : ValueObject
    {
        private readonly int value;

        public Intensity(int value)
        {
            Ensure.Argument.Is(value >= 0 && value <= 255, "Intensity value should be between 0 and 255.");
            this.value = value;
        }

        public static Intensity FromScalar(int value)
        {
            return new Intensity(value);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return value;
        }

        public static implicit operator int(Intensity intensity)
        {
            return intensity.value;
        }

        public static explicit operator Intensity(int value)
        {
            return new Intensity(value);
        }
    }
}
