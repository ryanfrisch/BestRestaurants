using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BestRestaurants.Models;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            List<string> topRestaurantsList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                string favdish;
                if (string.IsNullOrEmpty(r.FavDish))
                {
                    favdish = "It's all tasty!";
                }
                else
                {
                    favdish = r.FavDish;
                }
                topRestaurantsList.Add($"#{r.Rank}: {r.RestaurantName}. Favorite Dish: {favdish}. Address: {r.Address}. Phone: {r.Phone}. Website: {r.Website}");
            }

            return View(topRestaurantsList);
        }

        [HttpGet]
        public IActionResult EnterSuggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterSuggestions(Restaurant suggestionEntered)
        {
            //Makes sure form was valid before storing it to our temp storage, that way invalid forms aren't accepted.
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestionEntered);
            }
            return View();
        }

        public IActionResult ListSuggestions()
        {
            return View(TempStorage.Restaurant);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
