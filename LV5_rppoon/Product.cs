﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class Product : IShipable
    {
        private double price;
        private string description;
        private double weight;
        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
        public double Weight { get { return this.weight; } }
    }
}
