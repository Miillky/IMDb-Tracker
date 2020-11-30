using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("FavoriteMovies")]
    public class Movie {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        [ForeignKey("User")]
        [Required(AllowEmptyStrings = false)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
