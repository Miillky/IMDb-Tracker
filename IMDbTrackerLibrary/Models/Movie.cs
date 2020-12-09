﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Movie")]
    public class Movie {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }
    }
}
