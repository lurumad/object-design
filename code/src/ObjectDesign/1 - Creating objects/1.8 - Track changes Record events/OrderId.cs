namespace ObjectDesign.CreatingObjects.TrackChangesRecordEvents
{
    public class OrderId
    {
        private readonly int id;

        public OrderId(int id)
        {
            this.id = id;
        }

        public static OrderId New(int id)
        {
            return new OrderId(id);
        }
    }
}
