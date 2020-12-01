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

        [DataType(DataType.Password)]
        [MinLength(32)]
        [MaxLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        public string APIKey { get; set; }

        [Column(TypeName = "datetime2")]
        [Required(AllowEmptyStrings = false)]
        public DateTime LastLogin { get; set; } = DateTime.Now;

        [StringLength(32)]
        public string PasswordResetKey { get; set; } = null;

        [Column(TypeName = "datetime2")]
        public DateTime? PasswordResetKeyValid { get; set; } = null;
    }
}
