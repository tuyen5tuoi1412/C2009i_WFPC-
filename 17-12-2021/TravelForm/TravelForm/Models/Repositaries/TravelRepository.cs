using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelForm.Models;

namespace TravelForm.Models.Repositaries
{
    public class TravelRepository
    {
        public List<Travel> GetTravels()
        {
            //get data somewhere
            return new List<Travel>()
            {
                new Travel()
                {
                       TravelId = 1,
                       From = "Ha Noi",
                       To = "HCM city",
                       Price = 11234.55,
                       StartDate = new DateTime(2021,12,30)
                },
                 new Travel()
                {
                       TravelId = 1,
                       From = "Ha Noi",
                       To = "HCM city",
                       Price = 11234.55,
                       StartDate = new DateTime(2021,12,30)
                },
                  new Travel()
                {
                       TravelId = 1,
                       From = "Ha Noi",
                       To = "HCM city",
                       Price = 11234.55,
                       StartDate = new DateTime(2021,12,30)
                },
                   new Travel()
                {
                       TravelId = 1,
                       From = "Ha Noi",
                       To = "HCM city",
                       Price = 11234.55,
                       StartDate = new DateTime(2021,12,30)
                },
            };
        }
    }
}
