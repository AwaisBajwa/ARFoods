using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    class Customer
    {
        private string Customer_ID;
        private string Customer_Name;
        private string Customer_type;
        private string phoneNumber;
        private string mobileNumber;
        private string cnic;
        private string pAddress;
        private string tAddress;
        private string bAddress;
        private string email;
        private int Fax;
        private int C_gstRegNum;
        private int NTN;
        private int CreditLimit;
        private string creditTerms;
        private string CompanyName;

        #region Properties

        public string ID
        {
            get { return Customer_ID; }
            set { Customer_ID = value; }
        }

        public string Name
        {
            get { return Customer_Name; }
            set { Customer_Name = value; }
        }

        public string Type
        {
            get { return Customer_type; }
            set { Customer_type = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Company_Name
        {
            get { return CompanyName; }
            set { CompanyName = value; }
        }


        public string CreditTerms
        {
            get { return creditTerms; }
            set { creditTerms = value; }
        }

        public int Credit_Limit
        {
            get { return CreditLimit; }
            set { CreditLimit = value; }
        }

        public int NTN_Number
        {
            get { return NTN; }
            set { NTN = value; }
        }


        public int C_gstRegNumber
        {
            get { return C_gstRegNum; }
            set { C_gstRegNum = value; }
        }


        public int FaxNum
        {
            get { return Fax; }
            set { Fax = value; }
        }



        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }    

        #endregion
    }
}
