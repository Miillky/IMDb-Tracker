using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("MovieComments")]
    public class MovieComment {
        [Key]
        public int Id { get; set; }
        
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string MovieId { get; set; }
        public virtual Movie Show { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [StringLength(500)]
        [Required(AllowEmptyStrings = true)]
        public string Comment { get; set; }
    }
}
