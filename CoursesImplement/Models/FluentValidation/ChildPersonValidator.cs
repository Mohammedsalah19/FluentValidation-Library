using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesImplement.Models.FluentValidation
{
    public class ChildPersonValidator : AbstractValidator<ChildPerson>
    {

        public ChildPersonValidator()
        {
            RuleFor(x => x.job).NotEmpty().WithMessage("Job validation from child validation class");

        }
    }
}
