using System;

namespace ObjectDesign.CreatingObjects.TrackChangesRecordEvents
{
    public class OrderId
    {
        private readonly Guid id;

        public OrderId(Guid id)
        {
            this.id = id;
        }

        public static OrderId New(Guid id)
        {
            return new OrderId(id);
        }
    }
}
