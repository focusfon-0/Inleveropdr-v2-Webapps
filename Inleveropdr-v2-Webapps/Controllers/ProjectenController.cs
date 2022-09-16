using Inleveropdr_v2_Webapps.Data;
using Inleveropdr_v2_Webapps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Inleveropdr_v2_Webapps.Controllers
{
    public class ProjectenController : Controller
    {
        private readonly AppDbContext database;

        public ProjectenController(AppDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            IEnumerable<Projecten> objProjectenList = database.Projecten;
            return View(objProjectenList);
        }

        public IActionResult AddOrEdit()
        {
            return View(new ProjectenTransactie());
        }
    }
}
