using Microsoft.AspNetCore.Mvc;
using TrackingService.APIs.Common;
using TrackingService.Infrastructure.Models;

namespace TrackingService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class OrderFindManyArgs : FindManyInput<Order, OrderWhereInput> { }
