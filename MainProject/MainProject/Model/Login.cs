using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    public class Login:ViewModelBaseValidation
    {
        #region Attributes
        private Employee employee;
        private string _username;
        private string _password;
        private string _type;
        #endregion

        #region Properties
        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public string Username
        {
            get { return _username; }
            set 
            { 
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion

    }
}
