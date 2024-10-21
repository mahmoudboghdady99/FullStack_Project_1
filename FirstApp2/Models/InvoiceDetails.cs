using System.ComponentModel.DataAnnotations;

namespace FirstApp2.Models
{
    public class InvoiceDetails
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        [Required(ErrorMessage = "please enter price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "please enter quantity")]
        public int Quantity { get; set; }
    }
}
