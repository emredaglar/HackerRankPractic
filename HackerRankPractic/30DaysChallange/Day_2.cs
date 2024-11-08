﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankPractic._30DaysChallange
{
    internal class Day_2
    {
        class Result
        {

            /*
             * Complete the 'solve' function below.
             *
             * The function accepts following parameters:
             *  1. DOUBLE meal_cost
             *  2. INTEGER tip_percent
             *  3. INTEGER tax_percent
             */

            public static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
                double tip = (meal_cost * 100)/ tip_percent;
                double tax = (meal_cost*100)/tax_percent;
                int price = Convert.ToInt32(meal_cost+tip+tax);
                Console.WriteLine(price);


            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

                int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

                int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

                Result.solve(meal_cost, tip_percent, tax_percent);
            }
        }
    }
}
