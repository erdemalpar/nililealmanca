using System.ComponentModel.DataAnnotations;

namespace GermanLearningApp.Mvc.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sınıf bilgisi zorunludur.")]
        public string Class { get; set; }
    }
}
