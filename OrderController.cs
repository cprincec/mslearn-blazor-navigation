// [HttpGet("{orderId}")]
// public async Task<ActionResult<OrderWithStatus>> GetOrderWithStatus(int orderId)
// {
//     var order = await _db.Orders
//         .Where(o => o.OrderId == orderId)
//         .Include(o => o.Pizzas).ThenInclude(p => p.Special)
//         .Include(o => o.Pizzas).ThenInclude(p => p.Toppings).ThenInclude(t => t.Topping)
//         .SingleOrDefaultAsync();

//     if (order == null)
//     {
//         return NotFound();
//     }

//     return OrderWithStatus.FromOrder(order);
// }