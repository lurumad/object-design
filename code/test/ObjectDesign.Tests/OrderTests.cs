using FluentAssertions;
using ObjectDesign.CreatingObjects.TrackChangesRecordEvents;
using System.Linq;
using Xunit;

namespace ObjectDesign.Tests
{
    public class order_should
    {
        [Fact]
        public void allow_to_be_cancelled()
        {
            var order = Order.Place();
            order.Cancel();
            order.Events.Should().HaveCount(2);
            order.Events.ElementAt(0).Should().BeOfType<OrderOpened>();
            order.Events.ElementAt(1).Should().BeOfType<OrderCancelled>();
        }
    }
}

