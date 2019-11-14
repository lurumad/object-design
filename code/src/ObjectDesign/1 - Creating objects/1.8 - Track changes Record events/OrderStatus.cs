using System.Collections.Generic;

namespace ObjectDesign.CreatingObjects.TrackChangesRecordEvents
{
    public class OrderStatus
    {
        private static readonly IDictionary<int, OrderStatus> statuses = new Dictionary<int, OrderStatus>();

        public static readonly OrderStatus Open = new OrderStatus(1, nameof(Open));
        public static readonly OrderStatus Closed = new OrderStatus(2, nameof(Closed));
        public static readonly OrderStatus Pending = new OrderStatus(3, nameof(Pending));
        public static readonly OrderStatus Canceled = new OrderStatus(4, nameof(Canceled));
        public static readonly OrderStatus Processing = new OrderStatus(5, nameof(Processing));

        private OrderStatus(int id, string name)
        {
            this.id = id;
            this.name = name;
            statuses.Add(id, this);
        }

        internal int id;
        internal string name;

        public static IReadOnlyCollection<OrderStatus> Values => statuses.Values as IReadOnlyCollection<OrderStatus>;
    }
}
