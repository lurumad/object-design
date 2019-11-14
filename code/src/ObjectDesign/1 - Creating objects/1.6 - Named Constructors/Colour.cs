namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Colour
    {
        private readonly Intensity red;
        private readonly Intensity green;
        private readonly Intensity blue;

        public Colour(int red, int green, int blue)
        {
            this.red = (Intensity)red;
            this.green = (Intensity)green;
            this.blue = (Intensity)blue;
        }
    }
}
