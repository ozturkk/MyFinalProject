﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //validation:doğrulama---eklenen nesnenin yapısal olarak uygunluğununn incelendiği kısım. Karakter sayısının komtrolü gibi
        //Kurallar constructor içine yazılır
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);//productname nin uzunluğu minimum iki karakter olmalıdır
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//kategori ıd=1 olan ürünün fiyatını kuralladık
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalıdır");
           
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
