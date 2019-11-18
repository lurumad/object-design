using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.TrackChangesRecordEvents
{
    public class Order
    {
        internal OrderId id;
        internal OrderStatus status;
        private readonly List<IEvent> events = new List<IEvent>();
        public IReadOnlyCollection<IEvent> Events => events;

        private Order(OrderId id)
        {
            this.id = id;
            status = OrderStatus.Open;
            events.Add(OrderOpened.Create());
        }

        public static Order Place(OrderId id)
        {
            return new Order(id);
        }

        public void Cancel()
        {
            Ensure.That<DomainException>(status.id != OrderStatus.Canceled.id, "The order was already cancelled.");
            status = OrderStatus.Canceled;
            events.Add(OrderCancelled.Create());
        }
    }
}
