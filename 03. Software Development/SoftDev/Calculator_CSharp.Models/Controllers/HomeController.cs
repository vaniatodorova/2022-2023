using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator_CSharp.Models.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index(Calculator calculator)
		{
			return View(calculator);
		}
		[HttpPost]
		public ActionResult Calculate(Calculator calculator)
		{
			calculator.Result = CalculateResult(calculator);

			return RedirectToAction("Index", calculator);
		}

		private decimal CalculateResult(Calculator calculator)
		{
			var result = 0m;
			switch (calculator.Operator)
			{
				case "+":
					result = calculator.LeftOperand + calculator.RightOperand;
					break;
				case "-":
					result = calculator.LeftOperand - calculator.RightOperand;
					break;
				case "*":
					result = calculator.LeftOperand * calculator.RightOperand;
					break;
				case "/":
					result = calculator.LeftOperand / calculator.RightOperand;
					break;
			}
			return result;
		}
	}
}