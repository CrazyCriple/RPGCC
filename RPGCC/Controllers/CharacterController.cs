using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPGCC.Models;
using RPGCC.Models.Wizard;

namespace RPGCC.Controllers
{
	public class CharacterController : Controller
	{
		//
		// GET: /Character/
		public ActionResult Index()
		{
			return View("BasicDetails");
			
		}

        [HttpPost]
        public ActionResult BasicDetails(BasicDetails data, string prevBtn, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    Character obj = GetCharacter();
                    obj.Name= data.CharakterName;
                    obj.Gender = data.Gender;
                    obj.Age = data.Age;
                    obj.Concept = data.Concept;
                    obj.Description = data.Description;
                    return View("BasicStats");
                }
            }
            return View();

        }

        [HttpPost]
        public ActionResult BasicStats(BasicStats data, string prevBtn, string nextBtn)
        {
            Character obj = GetCharacter();
            if (prevBtn != null)
            {
                BasicDetails bd = new BasicDetails();
                bd.CharakterName = obj.Name;
                bd.Gender = obj.Gender;
                bd.Age= obj.Age;
                bd.Concept = obj.Concept;
                bd.Description = obj.Description;
                
                return View("BasicDetails", bd);
            }
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.Assets = data.Assets;
                    obj.SagaSkills = data.SagaSkills;
                    obj.Traits = data.Traits;
                    return View("Finishing");
                }
            }
            return View();
        }


<<<<<<< HEAD
        [HttpPost]
        public ActionResult Finishing(string prevBtn, string nextBtn)
=======
        public ActionResult Wizard()
        {
            var character = new Character("noname");

            //Choose name / age and gender

            //Choose concept

            //Choose Assets

            //Choose Skills

            //Choose Traits


        }

        /// <summary>
        /// Only for testing
        /// </summary>
        private Character CreateTestChar()
>>>>>>> ae145c4c2e9bb6edcedd91e1c4b64ce1a43420b2
        {
            Character obj = GetCharacter();
            if (prevBtn != null)
            {
                BasicStats bs = new BasicStats();
                bs.Assets= obj.Assets;
                bs.SagaSkills = obj.SagaSkills;
                bs.Traits = obj.Traits;
                return View("BasicStats", bs);
            }
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    //todo: save to DB
                    //db.Customers.Add(obj);
                    //db.SaveChanges();
                    
                    RemoveCharacter();
                    return View("Success");
                }
            }
            return View();
        }


		public ActionResult Edit()
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
			char1.Assets.Force = 5;
			char1.Assets.Fortune = 4;
			char1.Assets.Grace = 1;
			char1.Assets.Acuity = 3;

			char1.Description = "He awesome";
			char1.Gender = Gender.Male;
			return char1;

		}



		private Character GetCharacter()
		{
			if (Session["character"] == null)
			{
				Session["character"] = new Character("noname");
			}
			return (Character) Session["character"];

		}

		private void RemoveCharacter()
		{
			Session.Remove("character");
		}
	}
}