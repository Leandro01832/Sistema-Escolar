using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaEscolar.Data;
using SistemaEscolar.Models;

namespace SistemaEscolar.Controllers
{
    public class ContaController : Controller
    {
        public ContaController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            UserManager = userManager;
            Context = context;
        }
        
        public UserManager<IdentityUser> UserManager { get; }
        public ApplicationDbContext Context { get; }

        [Authorize(Roles ="Admin")]
        public IActionResult CrudEndPoint()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AlunoWeb aluno)
        {
            await UserManager.CreateAsync(new IdentityUser { UserName = aluno.Email }, aluno.Password);
            Context.Aluno.Add(new Aluno { Nome = aluno.Nome, Email = aluno.Email });
            await Context.SaveChangesAsync();
            return Redirect(Url.Content("~/"));
        }
    }
}