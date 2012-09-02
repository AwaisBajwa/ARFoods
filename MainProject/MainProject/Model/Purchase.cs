using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    class Purchase
    {
        private int PurchaseID;
        private string purchaseType;
        private string purchaseStatus;
        private int purchaseUnit;
        private decimal purchaseQuantity;
        private decimal purchasePrice;
        private DateTime orderedDate;
        private DateTime getDate;
        private decimal purchaseRate;
        private string location;
        private string Description;
        private int purchaseTax;
        private string termsOfPayment;


        public string TermsOfPayment
        {
            get { return termsOfPayment; }
            set { termsOfPayment = value; }
        }
        public int PurchaseTax
        {
            get { return purchaseTax; }
            set { purchaseTax = value; }
        }


        public string Purchase_Description
        {
            get { return Description; }
            set { Description = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public decimal PurchaseRate
        {
            get { return purchaseRate; }
            set { purchaseRate = value; }
        }

        public DateTime GetDate
        {
            get { return getDate; }
            set { getDate = value; }
        }

        public DateTime OrderedDate
        {
            get { return orderedDate; }
            set { orderedDate = value; }
        }

        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }

        public decimal PurchaseQuantity
        {
            get { return purchaseQuantity; }
            set { purchaseQuantity = value; }
        }

        public int PurchaseUnit
        {
            get { return purchaseUnit; }
            set { purchaseUnit = value; }
        }

        public string PurchaseStatus
        {
            get { return purchaseStatus; }
            set { purchaseStatus = value; }
        }

        public string PurchaseType
        {
            get { return purchaseType; }
            set { purchaseType = value; }
        }

        public int Purchase_ID
        {
            get { return PurchaseID; }
            set { PurchaseID = value; }
        }

    }
}
