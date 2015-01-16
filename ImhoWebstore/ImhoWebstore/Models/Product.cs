﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImhoWebstore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}