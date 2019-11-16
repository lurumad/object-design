using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    /// <summary>
    /// Represents a colour to be displayed on a screen with 24-bit colour depth.
    /// </summary>
    public class Colour
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;

        public Colour(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }
}
