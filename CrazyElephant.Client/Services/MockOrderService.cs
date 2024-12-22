namespace CrazyElephant.Client.Services
{
    internal class MockOrderService : IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            System.IO.File.WriteAllLines(System.IO.Path.Combine(Environment.CurrentDirectory, "Order.txt"), dishes.ToArray());
        }
    }
}
