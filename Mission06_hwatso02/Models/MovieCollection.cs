using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_hwatso02.Models
{
    //form info, set key and required fields
    public class MovieCollection
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int CategoryId { get; set; }
        //Build Foreign Key
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public ushort Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int RatingId { get; set; }
        //Build Foreign Key
        public Rating Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
