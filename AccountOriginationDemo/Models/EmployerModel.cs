using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class EmployerModel
    {
        public EmployerModel()
        {
            Employed = new Employed();
            RetirementBenefit = new RetirementBenefit();
            Student = new Student();
        }

        [Required(ErrorMessage = "Missing Employment Status")]
        public string? EmployStatus { get; set; }

        [ValidateComplexType]
        public Employed? Employed { get; set; }

        [ValidateComplexType]
        public RetirementBenefit? RetirementBenefits { get; set; }

        [ValidateComplexType]
        public RetirementBenefit? RetirementBenefit { get; set; }

        [ValidateComplexType]
        public Student? Student { get; set; }
    }

    public class Employed
    {
       public string? Industry { get; set; }
       public string? EmployerName { get; set; }
       public string? WorkNumber { get; set; }
       public string? WorkExtension { get; set; }
    }

    public class RetirementBenefit
    {
        public bool YesWithOverdraft { get; set; }
        public bool YesNoOverdraft { get; set; }
        public bool NoChecking { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "At least one choice is required")]
         public bool OneChoiceSelected
        {
            get
            {
                return ((YesWithOverdraft) || (YesNoOverdraft) || (NoChecking));
            }
            set { }
        }
    }

    public class Student
    {
        public string? NameOfUniversity { get; set; }
    }
}
