using TrackingService.Infrastructure;

namespace TrackingService.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(TrackingServiceDbContext context)
        : base(context) { }
}
