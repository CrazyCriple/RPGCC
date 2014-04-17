using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using MVC.Wizard.Controllers;
using MVC.Wizard.Web.ViewModels;
using RPGCC.Models;
using RPGCC.ViewModels;

namespace MVC.Wizard.Web.Controllers
{
    public class CharacterWizardController : WizardController
    {

        public ActionResult Index()
        {
            InitializeWizard();
            var vm = new CharacterWizardViewModel("This is just some demo text to indicate that you can use startup data.");

            return View(vm);
        }

        [HttpGet]
        public ActionResult Expert()
        {
            var character = new Character();
            return View(character);
        }

        [HttpPost]
        public ActionResult Expert(Character character)
        {
            if (character.Assets.Primary == character.Assets.Secondary)
            {
                throw new Exception("Meinsch ich überprüef dini agabe? haha ersti und zwöiti stärchi döf dänk ned di glich si..");
            }

            var list = new List<string>();

            list.Add(character.Assets.Primary);
            list.Add(character.Assets.Secondary);
            list.Add("Glück");

            //ugly I know :D fuck it, it works
            var missing = character.Assets.AssetNames.Except(list).ToList();

            character.Assets.Assets.Add(new KeyValuePair<string, int>(character.Assets.Primary,5));
            character.Assets.Assets.Add(new KeyValuePair<string, int>(character.Assets.Secondary, 3));
            character.Assets.Assets.Add(new KeyValuePair<string, int>("Glück", 4));
            character.Assets.Assets.Add(new KeyValuePair<string, int>(missing.FirstOrDefault(), 1));

            return View("Expert2",character);
        }

        [HttpGet]
        public ActionResult Expert2(Character character)
        {
            return View(character);
        }

        [HttpPost]
        public ActionResult ExpertSave(Character character)
        {
            return View();
        }

        protected override void ProcessToNext(Wizard.ViewModels.WizardViewModel model)
        {
            // Do here some custom things if you navigate to the next step.

            if (model.GetType() == typeof(CharacterWizardViewModel))
            {
                // Check the type so you could use multiple wizards in one controller.
            }
        }

        protected override void ProcessToPrevious(Wizard.ViewModels.WizardViewModel model)
        {
            // Do here some custom things if you navigate to the next step.

            if (model.GetType() == typeof(CharacterWizardViewModel))
            {
                // Check the type so you could use multiple wizards in one controller.
            }
        }

    }
}