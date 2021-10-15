using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCandidato.Data.Validation
{
    public class BeforeNowAttribute : ValidationAttribute
    {
        public BeforeNowAttribute() { }
        public string GetErrorMessage() => "Data precisa ser antes de hoje";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;

            if (DateTime.Compare(date, DateTime.Now) > 0) return new ValidationResult(GetErrorMessage());
            else return ValidationResult.Success;
        }

    }
}
