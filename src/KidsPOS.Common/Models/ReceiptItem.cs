namespace KidsPOS.Common.Models
{
    public class ReceiptItem
    {
        public int ReceiptItemId { get; set; }

        public int ReceiptId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Product Product { get; set; }
    }
}
