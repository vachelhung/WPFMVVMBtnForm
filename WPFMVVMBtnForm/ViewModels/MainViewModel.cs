using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFMVVMBtnForm.Views;

namespace WPFMVVMBtnForm.ViewModels
{
    internal class MainViewModel : NotifyPropertyBase
    {
        private Form1 form1 = new(); 

        private ICommand _clkShowForm1BtnCommand;
        public ICommand ClkShowForm1BtnCommand
        {
            get 
            {
                if (_clkShowForm1BtnCommand == null)
                {
                    _clkShowForm1BtnCommand = new RelayCommand((x) =>
                    {
                        form1.Show();
                        //form1.ShowDialog();
                    }
                    );
                }
                return _clkShowForm1BtnCommand; 
            }
        }

        private ICommand _clkCloseForm1BtnCommand;
        public ICommand ClkCloseForm1BtnCommand
        {
            get 
            {
                if (_clkCloseForm1BtnCommand == null)
                {
                    _clkCloseForm1BtnCommand = new RelayCommand((x) =>
                    {
                        form1.Close();
                    }
                    );
                }
                return _clkCloseForm1BtnCommand;
            }
        }
    }
}
