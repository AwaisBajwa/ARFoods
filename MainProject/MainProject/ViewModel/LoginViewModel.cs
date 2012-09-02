using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;
using ARFoods.Model;

namespace ARFoods.ViewModel
{
    public class LoginViewModel : ViewModelBaseValidation
    {

        #region Properties
        private Login login;
        public Login Login
        {
            get { return login; }
            set 
            { 
                login = value;
                OnPropertyChanged("Login");
            }
        }
        #endregion

        #region ICommands
        public LoginCommand LoginButtonCommand
        {
            get;
            set;
        }
        #endregion

        public LoginViewModel()
        {
            Login = new Login();
            LoginButtonCommand = new LoginCommand(this);
        }


        public void doLogin()
        {
            
        }

        

        public class LoginCommand : ICommand
        {
            private LoginViewModel viewModel;

            public LoginCommand(LoginViewModel viewModel)
            {
                this.viewModel = viewModel;
                this.viewModel.Login.PropertyChanged += (s, e) =>
                {
                    if (this.CanExecuteChanged != null)
                    {
                        this.CanExecuteChanged(this, new EventArgs());
                    }
                };
            }

            public bool CanExecute(object parameter)
            {
                if (!(string.IsNullOrEmpty(viewModel.Login.Username) || string.IsNullOrEmpty(viewModel.Login.Password)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                this.viewModel.doLogin();
            }
        }
         
    }


}
