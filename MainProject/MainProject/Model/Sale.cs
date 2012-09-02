using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    class Sale
    {
        private int saleID;
        private string saleType;
        private string saleStatus;
        private int saleUnit;
        private decimal saleQuantity;
        private decimal salePrice;
        private DateTime DeliveryDate;
        private DateTime orderDate;
        private string DeliveryLocation;
        private decimal saleRate;
        private string Description;
        private int saleTax;
        private string termsOfPayment;
        private string quotations;

        public string Quotations
        {
            get { return quotations; }
            set { quotations = value; }
        }

        public string TermsOfPayment
        {
            get { return termsOfPayment; }
            set { termsOfPayment = value; }
        }

        public int SaleTax
        {
            get { return saleTax; }
            set { saleTax = value; }
        }

        public string Sale_Description
        {
            get { return Description; }
            set { Description = value; }
        }

        public decimal SaleRate
        {
            get { return saleRate; }
            set { saleRate = value; }
        }

        public string Delivery_Location
        {
            get { return DeliveryLocation; }
            set { DeliveryLocation = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }


        public DateTime Delivery_Date
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }


        public decimal SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        public decimal SaleQuantity
        {
            get { return saleQuantity; }
            set { saleQuantity = value; }
        }

        public int SaleUnit
        {
            get { return saleUnit; }
            set { saleUnit = value; }
        }

        public string SaleStatus
        {
            get { return saleStatus; }
            set { saleStatus = value; }
        }


        public string SaleType
        {
            get { return saleType; }
            set { saleType = value; }
        }

        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

    }
}
