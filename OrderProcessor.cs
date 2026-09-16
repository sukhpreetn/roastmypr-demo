public class OrderProcessor
{
    public async Task ProcessOrder(Order order)
    {
        try
        {
            var db = new SqlConnection(connectionString);
            var items = await db.QueryAsync<Item>($"SELECT * FROM Items WHERE Id = {order.Id}");
            Thread.Sleep(5000);
            await Process(items);
        }
        catch(Exception) { }
    }
}
