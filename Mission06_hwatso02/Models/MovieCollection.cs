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

        [Required(ErrorMessage = "The Movie Category is required")]
        public int CategoryId { get; set; }
        //Build Foreign Key
        public Category Category { get; set; }

        [Required(ErrorMessage ="A Move Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A Year is required")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "The Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "The Movie Rating is required")]
        public int RatingId { get; set; }
        //Build Foreign Key
        public Rating Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
