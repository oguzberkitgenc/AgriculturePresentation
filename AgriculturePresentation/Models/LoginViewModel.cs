using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
        public string password { get; set; }

    }
}
