using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp0425.Command;
using WpfApp0425.Models;
using WpfApp0425.Views;

namespace WpfApp0425.ViewModels
{
    public class EditViewModel : INotifyPropertyChanged
    {
        private Printer _printer;
        public EditView EditView { get; set; }
        public Printer EditPrinter
        {
            get { return _printer; }
            set { _printer = value; OnPropertyChanged(); }
        }

        public RelayCommand SaveCommand { get; set; }

        public EditViewModel()
        {
            SaveCommand = new RelayCommand(
                (e)=> 
                {
                    MessageBox.Show("Data saved succesfully");
                    EditView.Close();
                });
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
