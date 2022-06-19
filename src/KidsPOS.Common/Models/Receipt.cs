namespace KidsPOS.Common.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }

        public DateTimeOffset Created { get; set; }

        public Guid OrderGuid { get; set; }

        public ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}
