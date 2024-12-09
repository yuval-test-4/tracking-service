using Microsoft.AspNetCore.Mvc;

namespace TrackingService.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
