
using System.Diagnostics;
using System.Threading.Tasks;
using business;
using business.Intermediario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEscolar.Data;
using SistemaEscolar.Models;
using SistemaEscolar.Models.Repository;

namespace SistemaEscolar.Controllers
{
    public class HomeController : Controller
    {
        public IRepositoryTurmaAluno RepositoryTurmaAluno { get; }
        public IReposiitoryTurma ReposiitoryTurma { get; }
        public UserManager<IdentityUser> UserManager { get; }
        public IRepositoryAluno RepositoryAluno { get; }
        public ApplicationDbContext Contexto { get; }

        public HomeController(IRepositoryTurmaAluno repositoryTurmaAluno, IReposiitoryTurma reposiitoryTurma,
             UserManager<IdentityUser> userManager, IRepositoryAluno repositoryAluno, ApplicationDbContext contexto)
        {
            RepositoryTurmaAluno = repositoryTurmaAluno;
            ReposiitoryTurma = reposiitoryTurma;
            UserManager = userManager;
            RepositoryAluno = repositoryAluno;
            Contexto = contexto;
        }

        public IActionResult Index()
        {
            var turmas = ReposiitoryTurma.GetAll();
            return View(turmas);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [Authorize]
        public IActionResult ParticiparTurma(int id)
        {
            Turma turma =  ReposiitoryTurma.Get(id);
            return View(turma);
        }

        // POST: Escola/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> ParticiparTurma(Turma turma)
        {
            var usuario = await UserManager.GetUserAsync(this.User);
            var aluno = RepositoryAluno.Get(usuario.UserName);

            Turma t = await Contexto.Turma.FirstOrDefaultAsync(d => d.Id == turma.Id);
            Aluno a = await Contexto.Aluno.Include(d => d.Turmas).FirstOrDefaultAsync(d => d.Id == aluno.Id);

            a.IncluiTurma(t);
            try
            {
                await Contexto.SaveChangesAsync();
                ViewBag.Mensagem = "Agora você esta em uma nova turma";
            }
            catch (System.Exception)
            {
                ViewBag.Mensagem = "Você já esta nesta turma";
            }
            return View("Parabens");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
