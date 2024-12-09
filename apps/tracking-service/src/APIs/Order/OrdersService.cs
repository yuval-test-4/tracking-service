using TrackingService.Infrastructure;

namespace TrackingService.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(TrackingServiceDbContext context)
        : base(context) { }
}
