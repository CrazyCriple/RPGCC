using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPGCC.Models;

namespace RPGCC.Controllers
{
    public class CharacterController : Controller
    {
        //
        // GET: /Character/
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Only for testing
        /// </summary>
        private void CreateTestChar()
        {
            var char1 = new Character("Ragnar Lovbrok");

            char1.Age = 28;
            char1.Concept = "Impaler";
            char1.Assets.Find(x => x.Name == "force").Value = 5;
            char1.Assets.Find(x => x.Name == "acuity").Value = 3;
            char1.Assets.Find(x => x.Name == "grace").Value = 1;

        }
	}
}