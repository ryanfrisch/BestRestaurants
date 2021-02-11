using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public class TempStorage
    {
            private static List<Restaurant> restaurants = new List<Restaurant>();

            public static IEnumerable<Restaurant> Restaurant => restaurants;

            public static void AddSuggestion(Restaurant restaurant)
            {
                restaurants.Add(restaurant);
            }
       
    }
}