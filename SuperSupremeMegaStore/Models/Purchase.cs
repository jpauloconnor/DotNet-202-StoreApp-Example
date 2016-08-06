namespace SuperSupremeMegaStore.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}