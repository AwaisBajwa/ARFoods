using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

public class ViewModelBaseValidation : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}

