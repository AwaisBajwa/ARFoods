using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    public class Employee
    {
        //attributes
        private int EmpID;
        private string EmpName;
        private string EmpFatherName;
        private string dob;
        private string Cnic;
        private string pAddress;
        private string tAddress;
        private string phoneNumber;
        private string mobileNumber;
        private string email;
        private string qualification;
        private string designation;
        private double salary;
        private DateTime hireDate;
        private string experties;
        private string dependency;
        




        //property
        public int EmployeeID
        {
            get { return EmpID; }
            set { EmpID = value; }
        }


        public string Name
        {
            get { return EmpName; }
            set { EmpName = value; }
        }


        public string FatherName
        {
            get { return EmpFatherName; }
            set { EmpFatherName = value; }
        }

        public string DateOfBirth
        {
            get { return dob; }
            set { dob = value; }
        }

        public string CNIC
        {
            get { return Cnic; }
            set { Cnic = value; }
        }

        public string PermanentAddress
        {
            get { return pAddress; }
            set { pAddress = value; }
        }

        public string TemporaryAddress
        {
            get { return tAddress; }
            set { tAddress = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }


        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Experties
        {
            get { return experties; }
            set { experties = value; }
        }        

        public string Dependency
        {
            get { return dependency; }
            set { dependency = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

    }
}
