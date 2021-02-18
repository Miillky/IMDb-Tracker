using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Movies")]
    public class Movie {
        [Key]
        [StringLength(150)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [StringLength(250)]
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        [StringLength(250)]
        [Required(AllowEmptyStrings = false)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "int")]
        [Range(0, 1000)]
        [Required]
        public int RunningTimeInMinutes { get; set; }

        [Column(TypeName = "float")]
        [Range(0, 10)]
        [Required]
        public float Rating { get; set; }

        [StringLength(250)]
        [Required(AllowEmptyStrings = false)]
        public string Genres { get; set; }

        [Column(TypeName = "int")]
        [Range(1800, 3000)]
        [Required]
        public int Year { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ReleaseDate { get; set; } = null;

        [StringLength(1000)]
        [Required(AllowEmptyStrings = true)]
        public string PlotOutline { get; set; }

        [StringLength(5000)]
        [Required(AllowEmptyStrings = true)]
        public string PlotSummary { get; set; } = null;
    }
}
