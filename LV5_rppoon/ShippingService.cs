using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class ShippingService
    {
        private double priceForKg;
        public ShippingService(double price)
        {
            this.priceForKg = price;
        }
        public double CalculateDeliveryPrice(double mass)
        {
            return priceForKg * mass;
        }
    }
}
