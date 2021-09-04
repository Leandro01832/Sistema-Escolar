using business.Intermediario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business
{
    public class Turma : BaseModel
    {
        public string LetraIdentificacao { get; set; }
        public int NumeroSala { get; set; }
        public string Materias { get; set; }
        public TimeSpan Horario { get; set; }
        public List<TurmaAluno> Alunos { get; set; }
        public int EscolaId { get; set; }
        public virtual Escola Escola { get; set; }
    }
}