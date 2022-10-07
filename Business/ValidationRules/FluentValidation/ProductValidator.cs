using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); //ProductName boş geçilemez.
            RuleFor(p => p.ProductName).MinimumLength(2); //ProductName en az 2 karakter olmalıdır.
            RuleFor(p => p.ProductName).MaximumLength(200); //ProductName en çok 200 karakter olabilir.
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage(Messages.WithStartA); ; //ProductName A ile başlamalı.

            RuleFor(p => p.UnitPrice).NotEmpty(); //UnitPrice boş geçilemez.
            RuleFor(p => p.UnitPrice).GreaterThan(0); //UnitPrice 0 olamaz.
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); // CategoryId'si 1 olan ürünlerin UnitPrice'ı 10 veya 10dan büyük olmalı.

            RuleFor(p => p.UnitsInStock).NotEmpty(); //UnitsInStock boş geçilemez.
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
