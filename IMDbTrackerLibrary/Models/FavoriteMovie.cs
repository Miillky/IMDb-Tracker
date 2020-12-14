using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("FavoriteMovies")]
    public class FavoriteMovie {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string MovieId { get; set; }
        public virtual Movie Movie { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
