public class OrderProcessor
{
    public async Task ProcessOrder(Order order)
    {
        await Process(order);
    }
}
