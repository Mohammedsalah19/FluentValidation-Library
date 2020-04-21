using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesImplement.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace CoursesImplement.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		[RuleSetForClientSideMessages("Create")]

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[RuleSetForClientSideMessages("Create")]

		public IActionResult Create(Person person)
		{

			if (!ModelState.IsValid)
			{ // re-render the view when validation failed.
				return View("Create", person);
			}
			TempData["notice"] = "Person successfully created";
			return RedirectToAction("Index");

		}

		[RuleSetForClientSideMessages("Edit")]

		public ActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		[RuleSetForClientSideMessages("Edit")]

		public IActionResult Edit(Person person)
		{

			if (!ModelState.IsValid)
			{ // re-render the view when validation failed.
				return View("Create", person);
			}
			TempData["notice"] = "Person successfully created";
			return RedirectToAction("Index");

		}
	}

}