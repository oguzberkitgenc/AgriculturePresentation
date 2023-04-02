using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator :AbstractValidator<Team>
    {
        public TeamValidator() 
        {
            RuleFor(x=>x.PersonName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x=>x.PersonName).MaximumLength(50).WithMessage("50 karakterden fazla olamaz");
            RuleFor(x=>x.PersonName).MinimumLength(6).WithMessage("6 karakterden az olamaz");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("50 karakterden fazla olamaz");
            RuleFor(x => x.Title).MinimumLength(6).WithMessage("6  karakterden az olamaz");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Boş geçilemez");
        }
    }
}
