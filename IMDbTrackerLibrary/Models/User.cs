using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMDbTrackerLibrary.Models {
    [Table("Users")]
    public partial class User {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        [StringLength(150)]
        public string UserName { get; set; }
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string FirstName { get; set; }
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string LastName { get; set; }
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Email { get; set; }
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Password { get; set; }
        [StringLength(150)]
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string APIKey { get; set; }
    }
}
