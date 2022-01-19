using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Easy
{
    class MaxUonTruck
    { 
    
        public static (int newTruckSize, int unitsLoadedFromProduct) fillTruck(int trucksize, int boxCountOfProduct, int unitsPerBox)
        {
            int newTruckSize = 0;
            int unitsLoadedFromProduct = 0;
            if (trucksize > boxCountOfProduct)
            {
                newTruckSize = trucksize - boxCountOfProduct;
                unitsLoadedFromProduct = boxCountOfProduct * unitsPerBox;
            }

            else 
            {
                newTruckSize = 0;
                unitsLoadedFromProduct = trucksize * unitsPerBox;

            }

            return (newTruckSize, unitsLoadedFromProduct);
        
        }


        public static int MaximumUnits(int[] boxCount, int[] unitsPerBox , int truckSize)
        {
            int unitsLoaded = 0;

            while (truckSize != 0)
            {
                int maxunitsPerBox = unitsPerBox.Max();

                int maxunitsPerBoxIndex = Array.IndexOf(unitsPerBox, maxunitsPerBox);

                var boxCountOfProductWithMaxUnits = boxCount[maxunitsPerBoxIndex];

                (int newTruckSize, int unitsLoadedFromProduct) = fillTruck(truckSize, boxCountOfProductWithMaxUnits, maxunitsPerBox);

                unitsLoaded += unitsLoadedFromProduct;

                truckSize = newTruckSize;

                unitsPerBox[maxunitsPerBoxIndex] = 0 ;
            }
            return unitsLoaded;
        }



        //public static void Main(string[] args)
        //{
        //    var res = MaximumUnits(new int[] { 1,2,3}, new int[] {3,2,1 }, 4);
        //}

    }

}
