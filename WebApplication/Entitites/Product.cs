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

<<<<<<< HEAD
        [Required]
        [MaxLength(50, ErrorMessage = "Product  Name should be required")]

=======
<<<<<<< HEAD
        [Required]
        [MaxLength(50, ErrorMessage = "Product  Name should be required")]

=======
>>>>>>> 457306fd5bd0d4c22be82a3425bb71a54fd3492b
>>>>>>> f963073ffca7a9008e1eb3270ddc308a4459e2c6
        public string ProductName { get; set; }

        public string Category { get; set; }
        public int Cost { get; set; }
        public bool ActiveInActive { get; set; }

        public string Description { get; set; }
    }
}
