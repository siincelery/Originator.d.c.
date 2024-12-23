using System.ComponentModel.DataAnnotations;

namespace Origi.Pages.Models
{
    public class Admin
    {
        [Key]
        public int Id_Admin { get; set; }

        [Required]
        [Display(Name = "Логин")]
        public string Login_Admin { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
