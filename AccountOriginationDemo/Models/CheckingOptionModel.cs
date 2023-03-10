using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class CheckingOptionModel
    {
        public string? CheckingSelection { get; set; }
        public string? DebitPinSelection { get; set; }
        public string? PaperCheckSelection { get; set; }
        public string? PrePrintedChecksSelection { get; set; }
    }
}
