using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A categoria precisa de um nome.")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Nota")]
        [Required(ErrorMessage = "O jogo precisa de uma nota.")]
        [Range(0, 100, ErrorMessage = "A nota deve ser entre 0 e 100.")]

        public int DisplayOrder { get; set; }

    }
}
