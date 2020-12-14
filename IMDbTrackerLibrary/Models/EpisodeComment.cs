using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("EpisodeComments")]
    public class EpisodeComment {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [StringLength(500)]
        [Required(AllowEmptyStrings = true)]
        public string Comment { get; set; }
    }
}
