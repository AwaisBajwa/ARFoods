using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    class Product
    {
        // attributes
        private int product_ID;
        private string product_Name;
        private string product_Type;
        private decimal quantity;
        private decimal unit;
        private decimal ratePerPacket;
        private decimal totalRate;
        private decimal weightPerPack;
        private decimal totalWeight;
        private string description;
        private string unitsOnStock;
        private int unitsInOrder;
        private string reOrderLevel;
        private int barcode;




        //property

        public int Product_ID
        {
            get { return product_ID; }
            set { product_ID = value; }
        }

        public string Product_Name
        {
            get { return product_Name; }
            set { product_Name = value; }
        }

        public string Product_Type
        {
            get { return product_Type; }
            set { product_Type = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public decimal RatePerPacket
        {
            get { return ratePerPacket; }
            set { ratePerPacket = value; }
        }

        public decimal TotalRate
        {
            get { return totalRate; }
            set { totalRate = value; }
        }
        public decimal WeightPerPack
        {
            get { return weightPerPack; }
            set { weightPerPack = value; }
        }

        public decimal TotalWeight
        {
            get { return totalWeight; }
            set { totalWeight = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string UnitsOnStock
        {
            get { return unitsOnStock; }
            set { unitsOnStock = value; }
        }

        public int UnitsInOrder
        {
            get { return unitsInOrder; }
            set { unitsInOrder = value; }
        }

        public string ReOrderLevel
        {
            get { return reOrderLevel; }
            set { reOrderLevel = value; }
        }

        public int Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

    }
}
