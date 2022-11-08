using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web.Models;

namespace Web.Controllers
{
    [Route("groups")]
    public class GroupsController : Controller
    {
        private static long currentGroupId = 1;
        private static List<GroupViewModel> groups = new List<GroupViewModel> { new GroupViewModel { Id = 1, Name = "Make`s Group" } };

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return View(groups);
        }
    }
}
