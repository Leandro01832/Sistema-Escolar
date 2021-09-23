using business.Intermediario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business
{
    public class Turma : BaseModel
    {
        [Display(Name ="Letra de identificação")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public string LetraIdentificacao { get; set; }
        [Display(Name = "Numero da sala")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public int NumeroSala { get; set; }
        [Display(Name = "Matérias")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public string Materias { get; set; }
        [Display(Name = "Horário")]
        [DataType(DataType.Time, ErrorMessage = "time em formato inválido")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public TimeSpan Horario { get; set; }
        public List<TurmaAluno> Alunos { get; set; }
        [Display(Name = "Escola")]
        [Required(ErrorMessage = "Este campo {0} é obrigatório ")]
        public int EscolaId { get; set; }
        public virtual Escola Escola { get; set; }
    }
}