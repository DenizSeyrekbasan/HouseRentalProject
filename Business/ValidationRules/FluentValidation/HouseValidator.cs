using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HouseValidator : AbstractValidator<House>
    {
        public HouseValidator()
        {
            //kurallar constructor icerisine yazilir
            RuleFor(p => p.HouseName).MinimumLength(2).WithMessage("Ev ismi 2 karakterden buyuk olmalidir !");
            RuleFor(p => p.HouseName).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);

            //RuleFor(p => p.Price).GreaterThanOrEqualTo(1000).When(p => p.HouseCategoryId == 1);
            //1 numarali kategoriId'si 1 oldugunda fiyat 1000'den buyuk veya esit olmali

            //RuleFor(p => p.HouseName).Must(StartWıthA);
            //Ev isimleri A ile baslamali 

        }

        private bool StartWıthA(string arg)
        {
            //bool true donerse kod calisacak
            return arg.StartsWith("A");
        }
    }
}
