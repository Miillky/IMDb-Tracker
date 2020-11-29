using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Users")]
    public partial class User {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [StringLength(32)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string APIKey { get; set; }

        [StringLength(64)]
        [Required(AllowEmptyStrings = false)]
        public string HashSalt { get; set; }

        [Column(TypeName="datetime2")]
        [Required]
        public DateTime LastLoginDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime LastPasswordReset {get; set; }
    }
}
