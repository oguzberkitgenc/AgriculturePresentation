using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklaması boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçilemez");

            RuleFor(x => x.Title).MaximumLength(20).WithMessage("20 Karakterden fazla girilemez");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("8 Karakterden az girilemez");

            RuleFor(x => x.Description).MinimumLength(20).WithMessage("20 Karakterden az girilemez");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("50 Karakterden fazla girilemez");
        }
    }
}
