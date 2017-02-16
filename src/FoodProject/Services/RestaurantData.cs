﻿using FoodProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodProject.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
                {
                    new Restaurant { Id = 1, Name="Tersiguel's"},
                    new Restaurant { Id = 2, Name="LJ's and the Kat"},
                    new Restaurant { Id = 2, Name="King's Convergence"}
                };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }
}
