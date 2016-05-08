using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class Coupon
    {
        public List<List<int>> CouponList { private get; set; }

        public void AddCoupons(int amountOfCoupons)
        {
            CouponList = new List<List<int>>();
            int amountOfNumbers = 6;
            Random randomNumber = new Random();
            int currentNumber = 0;
            for (int i = 0; i < amountOfCoupons; i++)
            {
                List<int> coupon = new List<int>(amountOfNumbers);
                for (int j = 0; j < amountOfNumbers; j++)
                {

                    currentNumber = randomNumber.Next(1, 50);
                    if (!coupon.Contains(currentNumber))
                    {
                        coupon.Add(currentNumber);
                    }
                    else amountOfNumbers++;
                }
                //if (i % 1000000 == 0) Console.WriteLine("Adding {0} coupon", i);
                CouponList.Add(coupon);

                //Console.WriteLine(string.Join(" ", coupon));  // Print the numbers, one coupon = one line

                if (CouponList.Contains(coupon))
                {
                    Console.WriteLine("You won!");
                }
                else Console.WriteLine("You did not win.");

                coupon.Clear();
                currentNumber = 0;
                amountOfNumbers = 6;
            }
            Console.WriteLine("Coupons adding finished successfully.");
        }

        public void CheckWinner(List<int> winningCoupon)
        {
            if (CouponList.Contains(winningCoupon))
            {
                Console.WriteLine("You won!");
            }
            else Console.WriteLine("You did not win.");
        }
    }
}
