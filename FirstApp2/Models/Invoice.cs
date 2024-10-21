namespace FirstApp2.Models
{
    public class Invoice
    {
        public Invoice()
        {
            InvoiceItems = new List<InvoiceDetails>();
        }
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public bool HasShipping { get; set; }

        public List<InvoiceDetails> InvoiceItems { get; set; }
    }
}
