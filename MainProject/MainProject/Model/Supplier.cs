using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    class Supplier
    {

        private int Supplier_ID;
        private string Supplier_Name;
        private string Supplier_type;
        private int Contact;
        private int cnic;
        private string Address;
        private string email;
        private int Fax;
        private int S_gstRegNum;
        private int NTN;
        private int CreditLimit;
        private string creditTerms;
        private string CompanyName;

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


        public int S_gstRegNumber
        {
            get { return S_gstRegNum; }
            set { S_gstRegNum = value; }
        }


        public int FaxNum
        {
            get { return Fax; }
            set { Fax = value; }
        }



        public string S_Address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Cnic
        {
            get { return cnic; }
            set { cnic = value; }
        }


        public string S_type
        {
            get { return Supplier_type; }
            set { Supplier_type = value; }
        }

        public string S_Name
        {
            get { return Supplier_Name; }
            set { Supplier_Name = value; }
        }


        public int Supplier_Id
        {
            get { return Supplier_ID; }
            set { Supplier_ID = value; }
        }
        public int S_Contact
        {
            get { return Contact; }
            set { Contact = value; }
        }
    }
}
