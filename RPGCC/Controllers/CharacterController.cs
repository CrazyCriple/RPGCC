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
            var char1 = CreateTestChar();
            return View(char1);
            
        }

        public ActionResult View1()
        {
            var char1 = CreateTestChar();
            return View(char1);

        }
        /// <summary>
        /// Only for testing
        /// </summary>
        private Character CreateTestChar()
        {
            var char1 = new Character("Ragnar Lovbrok");

            char1.Age = 28;
            char1.Concept = "Impaler";
            char1.Assets.Find(x => x.Name == "force").Value = 5;
            char1.Assets.Find(x => x.Name == "acuity").Value = 3;
            char1.Assets.Find(x => x.Name == "grace").Value = 1;

            char1.Description = "He awesome";
            char1.Gender = Gender.Male;
            return char1;

        }
	}
}