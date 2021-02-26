﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This is my PagingInfo Model
namespace Bookstore.Models.ViewModels
{
    public class PagingInfo
    {
        //Test
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int) (Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
