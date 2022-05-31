using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    [Table("PaymentDetail")]
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Required]       
        public string CardOwnerName { get; set; }
        
        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string SecurityCode { get; set; }
    }
}