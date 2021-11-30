using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class RegisterView
    {
        [Required(ErrorMessage = "O campo nome de usuário é obrigatrio.")]
        [Display(Name = "Nome de usuário")]
        //[Remote(action: "IsEmailInUse", controller: "Account")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatrio.")]
        [EmailAddress]
        [Display(Name = "E-mail")]
        //[Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatrio.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "O campo cidade é obrigatrio.")]
        [Display(Name = "Cidade")]
        public string City { get; set; }
    }
}
