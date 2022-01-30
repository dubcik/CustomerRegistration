using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRegFlorin.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string customerName { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string customerWebsite { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string customerEmail { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string customerPhone { set; get; }

        //CustomerPostalAddress 
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string addressStreet { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string addressNumber { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string addressCity { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string addressPostcode { set; get; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string addressCountry { set; get; }

        //CustomerInvoicinglAddress

        [Column(TypeName = "nvarchar(100)")]
        public string? addressStreet2 { set; get; }

        [Column(TypeName = "nvarchar(10)")]
        public string? addressNumber2 { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string? addressPostcode2 { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string? addressCity2 { set; get; }

        [Column(TypeName = "nvarchar(100)")]
        public string? addressCountry2 { set; get; }
    }
}
