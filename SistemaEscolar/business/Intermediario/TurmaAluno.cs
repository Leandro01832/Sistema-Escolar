using System;
using System.Collections.Generic;
using System.Text;

namespace business.Intermediario
{
    public class TurmaAluno 
    {
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public virtual Turma Turma { get; set; }
    }
}
