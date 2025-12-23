namespace CompanyAPI.DTOs
{
    public class CustomerDTO
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        public List<CustomerOrderDTO> Orders { get; set; }
    }
}