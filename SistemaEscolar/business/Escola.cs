using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace business
{
   public class Escola : BaseModel
    {
        [Required(ErrorMessage ="Este campo {0} é obrigatório ")]
        public string Nome { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public string Endereco { get; set; }
        public List<Turma> Turmas { get; set; }
    }
}
