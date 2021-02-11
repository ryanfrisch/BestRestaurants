using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        public int? Rank { get; }
        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string FavDish { get; set; }
        public string Address { get; set; }

        //FIX PHONE TYPE LATER?
        [Phone]
        [Required]
        public string Phone { get; set; }
        public string Website { get; set; } = "Coming soon.";
        public string UserName { get; set; }

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Penguin Brothers",
                FavDish = "'The Breakup' Pizookie",
                Address = "83 Cougar Blvd, Provo, UT 84604",
                Phone = "(801) 532-9537",
                Website = "thepenguinbrothers.com",
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Rockwell Ice Cream",
                FavDish = "'The Goat' ice cream cone",
                Address = "43 N University Ave, Provo, UT 84601",
                Phone = "(801) 318-5950",
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "J Dawgs",
                FavDish = "Polish Hot Dog",
                Address = "858 700 E, Provo, UT 84606",
                Website = "jdawgs.com",
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Cupbop",
                FavDish = "Rock Bop",
                Address = "700 E # 815, Provo, UT 84606",
                Phone = "(801) 607-5200",
                Website = "cupbop.com",
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Chip Cookie",
                Address = "470 N Freedom Blvd, Provo, UT 84111",
                Phone = "(385) 225-9888",
                Website = "chipcookies.co",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }

}
