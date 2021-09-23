using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEscolar.Models
{
    public class AlunoWeb : IdentityUser
    {

        public string Nome { get; set; }
    }
}
