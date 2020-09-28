using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entitites
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Category Name should be required")]
        public string CategoryName { get; set; }

        public bool ActiveInactive { get; set; }

        public string Description { get; set; }
    }
}
