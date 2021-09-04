using business.Intermediario;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business
{
    public class Aluno : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual List<TurmaAluno> Turmas { get; set; }
        
        public void IncluiTurma(Turma turma)
        {
            this.Turmas.Add(new TurmaAluno { Turma = turma });
        }
    }
}