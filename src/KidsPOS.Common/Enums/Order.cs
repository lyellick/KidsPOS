namespace KidsPOS.Common.Enums
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTimeOffset Created { get; set; }

        public Guid OrderGuid { get; set; }
    }
}
