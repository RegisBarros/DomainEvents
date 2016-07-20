namespace DomainEvents.Core.Stock.Models
{
    public class Stock
    {
        public int Quantity { get; set; }
        public int Minimum { get; set; }

        public bool AlertStock()
        {
            return Quantity <= Minimum;
        }
    }
}
