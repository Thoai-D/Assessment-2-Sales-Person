using System;

namespace Assessment_2_Sales_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson[] SalesPeople = new SalesPerson[6];
            SalesPeople[0] = new SalesPerson("100");
            SalesPeople[1] = new SalesPerson("101");
            SalesPeople[2] = new SalesPerson("102");

            SalesPeople[0].SetSalesHistory(new Sale("A100", 300, 10));
            SalesPeople[0].SetSalesHistory(new Sale("A200", 1000, 2));
            SalesPeople[1].SetSalesHistory(new Sale("A300", 2550.40, 10));

            Console.WriteLine(SalesPeople[2].GetID());
            Console.WriteLine(SalesPeople[0].GetCount());
            Console.WriteLine(SalesPeople[1].GetSalesHistory(0).GetValue());
            Console.WriteLine(SalesPeople[0].CalculateTotalSales());

        }
    }
}
