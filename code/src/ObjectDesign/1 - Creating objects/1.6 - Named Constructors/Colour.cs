using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    /// <summary>
    /// Represents a colour to be displayed on a screen with 24-bit colour depth.
    /// </summary>
    public class Colour : ValueObject
    {
        private readonly Intensity red;
        private readonly Intensity green;
        private readonly Intensity blue;

        private Colour(Intensity red, Intensity green, Intensity blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public static Colour FromRgb(Intensity red, Intensity green, Intensity blue)
        {
            return new Colour(red, green, blue);
        }

        public static Colour FromHsl(Hue hue, Saturation saturation, Lightness lighness)
        {
            byte r;
            byte b;
            byte g;

            if (saturation == 0)
            {
                r = g = b = (byte)(lighness * 255);
            }
            else
            {
                double v1, v2;
                double hueTemp = hue / 360;
                double saturationTemp = saturation / 100;
                double lighnessTemp = lighness / 100;
                v2 = (lighnessTemp < 0.5) ? (lighnessTemp * (1 + saturationTemp)) : (lighnessTemp + saturationTemp - (lighnessTemp * saturationTemp));
                v1 = 2 * lighnessTemp - v2;

                r = (byte)(255 * HueToRGB(v1, v2, hueTemp + (1.0f / 3)));
                g = (byte)(255 * HueToRGB(v1, v2, hueTemp));
                b = (byte)(255 * HueToRGB(v1, v2, hueTemp - (1.0f / 3)));
            }

            return new Colour(Intensity.FromScalar(r), Intensity.FromScalar(g), Intensity.FromScalar(b));
        }

        private static double HueToRGB(double v1, double v2, double vH)
        {
            if (vH < 0)
                vH += 1;

            if (vH > 1)
                vH -= 1;

            if ((6 * vH) < 1)
                return v1 + (v2 - v1) * 6 * vH;

            if ((2 * vH) < 1)
                return v2;

            if ((3 * vH) < 2)
                return v1 + (v2 - v1) * ((2.0f / 3) - vH) * 6;

            return v1;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return red;
            yield return green;
            yield return blue;
        }
    }
}
