using FluentAssertions;
using ObjectDesign.CreatingObjects.TrackChangesRecordEvents;
using System;
using System.Linq;
using Xunit;

namespace ObjectDesign.Tests
{
    public class order_should
    {
        [Fact]
        public void allow_to_be_cancelled()
        {
            var order = Order.Place(new OrderId(Guid.NewGuid()));
            order.Cancel();
            order.Events.Last().Should().BeOfType<OrderCancelled>();
        }
    }
}

