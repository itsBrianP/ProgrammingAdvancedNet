﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroWeek2.Models
{
    public class RestaurantReview
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public int Rating { get; set; }
    }
}