using FizzBuzzMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzMVCController : Controller
    {
        [HttpPost]
        public IActionResult Index(FizzBuzz FizzBuzz)
        {
           

            for (int i = 1; i <= 100; i++)
            {
                if(i % FizzBuzz.FizzValue == 0 && i % FizzBuzz.BuzzValue == 0)
                {
                    FizzBuzz.Results.Add("FizzBuzz");
                    
                } else if(i % FizzBuzz.FizzValue == 0)
                {
                    FizzBuzz.Results.Add("Fizz");
                } else if(i % FizzBuzz.BuzzValue == 0)
                {
                    FizzBuzz.Results.Add("Buzz");
                } else
                {
                    FizzBuzz.Results.Add(i.ToString() );
                }
                
            }

            
            return View(FizzBuzz);
        }

        public IActionResult Index()
        {
            FizzBuzz FizzBuzz = new FizzBuzz();
            FizzBuzz.FizzValue = 3;
            FizzBuzz.BuzzValue = 5;
            return View(FizzBuzz);
        }
    }
}
