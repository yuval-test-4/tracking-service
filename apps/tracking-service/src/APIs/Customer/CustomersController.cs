using Microsoft.AspNetCore.Mvc;

namespace TrackingService.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
