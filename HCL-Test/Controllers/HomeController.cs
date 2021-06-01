using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HCL_Test.Models;

namespace HCL_Test.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Series series)
        {
            if (ModelState.IsValid)
            {
                var tempList = GenerateSeries(series.NumberInSeries);
                series.DynamicSeries = string.Join(',', tempList);
                series.Output = GetDivisibleNumber(series.Divisor, series.Number, tempList);
                return View("Index",series);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private int GetDivisibleNumber(int divisor, int number, List<int> generatedSeries)
        {
            var counter = 0;
            var result = 0;
            for(int i =0; i<generatedSeries.Count; i++)
            {
                if(generatedSeries[i]%divisor==0)
                {
                    counter++;
                    if(counter == number)
                    {
                        result = generatedSeries[i];
                        break;
                    }
                }
            }
            return result;
        }

        private List<int> GenerateSeries(int numberOfSeries)
        {
            List<int> seriesList = new List<int>();
            seriesList.Add(1);
            seriesList.Add(1);
            seriesList.Add(1);
            for(int i=3; i< numberOfSeries; i++)
            {
                var item = seriesList[i - 1] + seriesList[i - 2] + seriesList[i - 3];
                seriesList.Add(item);
            }
            return seriesList;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
