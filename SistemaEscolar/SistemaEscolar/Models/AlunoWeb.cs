using Microsoft.AspNetCore.Identity;

namespace SistemaEscolar.Models
{
    public class AlunoWeb : IdentityUser
    {
        public string Nome { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
