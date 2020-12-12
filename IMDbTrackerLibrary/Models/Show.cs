using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Show")]
    public class Show {
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

        [Column(TypeName = "datetime2")]
        public DateTime? ReleseDate { get; set; } = null;
    }
}