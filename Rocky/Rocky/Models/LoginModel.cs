using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "O campo Nome de usuario é obrigatrio.")]
        [Display(Name = "Nome de usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatrio.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembrar Login")]
        public bool RememberMe { get; set; }
    }
}
