using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2_Sales_Person
{
    class Sale
    {
        private string ItemId;
        private double Value;
        private int Quantity;

        public Sale(string ItemId, double Value, int Quantity)
        {
            this.ItemId = ItemId;
            this.Value = Value;
            this.Quantity = Quantity;
        }

        public double GetValue()
        {
            return Value;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
