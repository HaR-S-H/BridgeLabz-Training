using System;

class ProfitPercentage
{
    static void Main()
    {  //   set cost price and selling price
        double costPrice = 129;

        double sellingPrice = 191;
        //  calculate profit and profit percentage
        double profit = sellingPrice - costPrice;

        double profitPercent = (profit / costPrice) * 100;
        // print the result
        Console.WriteLine(
            $"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
            $"The Profit is INR {profit} and the Profit Percentage is {profitPercent}%"
        );
    }
}
