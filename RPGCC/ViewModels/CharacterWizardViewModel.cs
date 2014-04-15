using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVC.Wizard.ViewModels;
using MVC.Wizard.Web.ViewModels;
using RPGCC.Models;

namespace RPGCC.ViewModels
{
    public class CharacterWizardViewModel : WizardViewModel
    {    

        private const int numberOfSteps = 3;

        public CharacterWizardViewModel()
            : base(numberOfSteps)
        {
            Step1 = new CharacterWizardViewModelStep1();
            Step2 = new CharacterWizardViewModelStep2();
            Step3 = new CharacterWizardViewModelStep3();
            //Step4 = new CharacterWizardViewModelStep4();
            //Step5 = new CharacterWizardViewModelStep5();
            //Step6 = new CharacterWizardViewModelStep6();
        }

        public CharacterWizardViewModel(string initialWizardValue)
            : this()
        {
            Step1.Name = initialWizardValue;
        }

        [Display(Name = "Wer ist dein Charakter?")]
        public CharacterWizardViewModelStep1 Step1 { get; set; }

        [Display(Name = "Was kann dein Charakter?")]
        public CharacterWizardViewModelStep2 Step2 { get; set; }

        [Display(Name = "Fast fertig")]
        public CharacterWizardViewModelStep3 Step3 { get; set; }

        //[Display(Name = "Custom title for step 4")]
        //public SampleWizardViewModelStep4 Step4 { get; set; }

        //[Display(Name = "Custom title for step 5")]
        //public SampleWizardViewModelStep5 Step5 { get; set; }

        //[Display(Name = "Custom title for step 6")]
        //public SampleWizardViewModelStep6 Step6 { get; set; }

    }
    
    public class CharacterWizardViewModelStep1 : WizardStep
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Geschlecht", Prompt = "Wähle das Geschlecht deines Charakters")]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Alter")]
        public int Age { get; set; }

        [Display(Name = "Charakter Konzept")]
        public string Concept { get; set; }

        [Display(Name = "Beschreibung")]
        public string Description { get; set; }
    }

    public class CharacterWizardViewModelStep2 : WizardStep
    {

        [Required]
        public int? Required { get; set; }

        public string NotRequired { get; set; }

    }

    public class CharacterWizardViewModelStep3 : WizardStep
    {

        [Required]
        public int? RequiredDirectUpdate { get; set; }

        [Required]
        public string MyProperty { get; set; }

        [StringLength(3)]
        public string StringLengthDirectUpdate { get; set; }

    }

    public class CharacterWizardViewModelStep4 : WizardStep, IValidatableObject
    {

        [Required]
        public int? RequiredNoClientValidation { get; set; }

        public string NotRequiredNoClientValidation { get; set; }

        [Required]
        public int? HigherThan17AndRequired { get; set; }

        public override bool EnableClientValidation
        {
            get { return false; }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var higherThan17Property = new[] { "HigherThan17AndRequired" };

            // Check if the value is higher than 17
            if (!HigherThan17AndRequired.HasValue)
            {
                results.Add(new ValidationResult(
                      "HigherThan17AndRequired is required and must be a number",
                      higherThan17Property));
            }
            else if (HigherThan17AndRequired.Value < 18)
            {
                results.Add(new ValidationResult(
                    "HigherThan17AndRequired is not higher than 17",
                    higherThan17Property));
            }

            return results;
        }

    }

    public class CharacterWizardViewModelStep5 : WizardStep, IValidatableObject
    {

        [Required]
        public bool IAgree { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var IAgreeProperty = new[] { "IAgree" };

            // some other random validation
            if (!IAgree)
            {
                results.Add(new ValidationResult(
                      "You have to agree to proceed",
                      IAgreeProperty));
            }

            return results;
        }

    }

    public class CharacterWizardViewModelStep6 : WizardStep
    {

    }
}