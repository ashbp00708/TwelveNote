using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(3, ErrorMessage ="Enter a full length category name.")]
        [MaxLength(50, ErrorMessage ="Category name is too long.")]
        public string Name { get; set; }
        [Required]
        [MinLength(1, ErrorMessage ="Enter valid number.")]
        [MaxLength(3, ErrorMessage ="Exceeds limit of categories that can be created.")]
        public Guid Number { get; set; }
        [Required]
        [MaxLength(2000)]    
        public string Description { get; set; }

    }
}
