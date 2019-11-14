namespace ObjectDesign.CreatingObjects.NamedConstructors
{
    public class Reservation
    {
        private Reservation()
        {

        }

        public static Reservation Make()
        {
            return new Reservation();
        }
    }
}
