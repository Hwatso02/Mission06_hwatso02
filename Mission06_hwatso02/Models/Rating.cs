using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_hwatso02.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int RatingId { get; set; }
        public string RatingName { get; set; }
    }
}
