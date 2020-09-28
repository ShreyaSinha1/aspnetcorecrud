using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Product  Name should be required")]
        public string ProductName { get; set; }

        public string Category { get; set; }
        public int Cost { get; set; }
        public bool ActiveInActive { get; set; }

        public string Description { get; set; }
    }
}
