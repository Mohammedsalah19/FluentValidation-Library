using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesImplement.Models.FluentValidation
{
	public class PersonValidator : AbstractValidator<Person>
	{
		public PersonValidator()
		{

			RuleSet("Create", () =>
			{
				RuleFor(x => x.Id).NotNull().WithMessage("Create rule Set");
				RuleFor(x => x.Name).Length(0, 10).WithMessage("Create rule Set");
				RuleFor(x => x.Email).EmailAddress().WithMessage("Create rule Set");
				RuleFor(x => x.Age).InclusiveBetween(18, 60).WithMessage("Create rule Set");
				RuleFor(x => x.child1).SetValidator(new ChildPersonValidator()).WithMessage("Create rule set");

 
			});


			RuleSet("Edit", () =>
			{
				RuleFor(x => x.Id).NotNull().WithMessage("Edit rule Set");
				RuleFor(x => x.Name).Length(0, 10).WithMessage("Edit rule Set");
				RuleFor(x => x.Email).EmailAddress().WithMessage("Edit rule Set");
				RuleFor(x => x.Age).InclusiveBetween(18, 60).WithMessage("Edit rule Set");

				RuleFor(x => x.child1).SetValidator(new ChildPersonValidator()).WithMessage("Edit rule set");


			});
		}

	



	}



}

