using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2_Sales_Person
{
    class SalesPerson
    {
        private string ID;
        private Sale[] SalesHistory;
        private int Count = 0;

        public SalesPerson(string ID)
        {
            this.ID = ID;
            SalesHistory = new Sale[100];
        }

        public int GetCount()
        {
            return Count;
        }

        public string GetID()
        {
            return ID;
        }

        public void SetSalesHistory(Sale s)
        {
            SalesHistory[Count] = s;
            Count++;
        }

        public Sale GetSalesHistory(int SaleNumber)
        {
            return SalesHistory[SaleNumber];
        }

        public double CalculateTotalSales()
        {
            double total = 0;
            for(int i = 0; i < SalesHistory.Length; i++)
            {
                if(SalesHistory[i] != null)
                {
                    total = total + (SalesHistory[i].GetValue() * SalesHistory[i].GetQuantity());
                }
            }
            return total;
        }
    }
}
