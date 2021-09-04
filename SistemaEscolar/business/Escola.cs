using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace business
{
   public class Escola : BaseModel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Turma> Turmas { get; set; }
    }
}
