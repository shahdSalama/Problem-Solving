using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class FreshPromo
    {
        private static int freshPromotion(string[][] codeList, string[] cart)
        {
            //  Start at 0 index for both the code list and shopping cart.
            int cartIdx = 0, codeIdx = 0;
            while (cartIdx < cart.Length && codeIdx < codeList.Length)
            {
                string currentFruit = cart[cartIdx];
                //  If the first fruit of the codeList is anything or if it matches the current fruit at the cart idx.
                if ((codeList[codeIdx][0].Equals("anything") 
                    || codeList[codeIdx][0].Equals(currentFruit)) 
                    && hasOrder(cart, cartIdx, codeList[codeIdx]))
                {
                    cartIdx += codeList[codeIdx++].Length;
                }
                else
                {
                    cartIdx++;
                }
            }
            //        If the all the codeList is present then return 1, else 0.
            return codeIdx == codeList.Length ? 1 : 0;
        }

        private static bool hasOrder(string[] cart, int cartIdx, string[] code)
        {
            //        Loop through the codeList to check if the fruits are in order.
            foreach(string fruit in code)
            {
                if (cartIdx < cart.Length && (fruit.Equals("anything") || cart[cartIdx].Equals(fruit)))
                {
                    cartIdx++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
