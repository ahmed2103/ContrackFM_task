namespace CompanyAPI.DTOs
{
    public class CustomerOrderDTO
    {
        public string OrderId { get; set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public Decimal TotalCost { get; set; }
    }
}
