using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaEscolar.Data;
using SistemaEscolar.Models;

namespace SistemaEscolar.Controllers
{
    public class ContaController : Controller
    {
        public ContaController()
        {
        }

        [Authorize(Roles ="Admin")]
        public IActionResult CrudEndPoint()
        {
            return View();
        }
    }
}