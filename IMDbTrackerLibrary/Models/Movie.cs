using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Movie")]
    public class Movie {
        [Key]
        [StringLength(150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = false)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "int")]
        [Range(0, 1000)]
        [Required]
        public int RunningTimeInMinutes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ReleseDate { get; set; } = null;
    }
}
