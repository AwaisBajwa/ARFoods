// Microsoft Developer & Platform Evangelism
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious. No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Windows.Input;
using System.Diagnostics;

public class RelayCommand : ICommand
{
    #region Member Fields
    public event EventHandler CanExecuteChanged;
    readonly Action<object> _execute;
    readonly Predicate<object> _canExecute;

    #endregion

    #region Constructors

    public RelayCommand(Action<object> execute)
        : this(null, execute)
    {
    }

    public RelayCommand(Predicate<object> canExecute, Action<object> execute)
    {
        if (execute == null)
        {
            throw new ArgumentNullException("execute");
        }
        
        _execute = execute;
        _canExecute = canExecute;
    }
    #endregion // Constructors

    #region ICommand Members



    [DebuggerStepThrough]
    public bool CanExecute(object parameter)
    {
        return _canExecute == null ? true : _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    public virtual void OnCanExecuteChanged(EventArgs args)
    {
        EventHandler temp = CanExecuteChanged;
        if (temp != null)
        {
            CanExecuteChanged(this, args);
        }
    }

    #endregion
}
