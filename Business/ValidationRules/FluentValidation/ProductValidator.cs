using System;
using FluentValidation;
using shopEntities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(p => p.Name).Length(2, 30);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThanOrEqualTo(1);
            RuleFor(p => p.Price).GreaterThanOrEqualTo(10).When(p => p.Category_id == 1);
            RuleFor(p => p.Name).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

