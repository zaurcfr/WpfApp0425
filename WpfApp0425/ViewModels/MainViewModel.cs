using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp0425.Command;
using WpfApp0425.Models;
using WpfApp0425.Repo;
using WpfApp0425.Views;

namespace WpfApp0425.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public FakeRepo PrinterRepository { get; set; }
        public ObservableCollection<Printer> Printers { get; set; }

        private Printer _printer;
        public Printer Printer
        {
            get { return _printer; }
            set { _printer = value; OnPropertyChanged(); }
        }

        public EditViewModel EditViewModel { get; set; }
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand SelectionChangedCommand { get; set; }

        public MainViewModel()
        {
            Printer = new Printer
            {
                Model = "Envy",
                Vendor = "HP",
                Color = "Black"
            };

            ShowCommand = new RelayCommand(
                (e) =>
                {
                    MessageBox.Show($"{Printer.Vendor} - {Printer.Model} - {Printer.Color}");
                },
                (c) =>
                {
                    if (Printer.Color.Length < 10) return true;
                    return false;
                }
            );

            EditCommand = new RelayCommand(
                (e) =>
                {
                    var view = new EditView();
                    EditViewModel = new EditViewModel();
                    EditViewModel.EditPrinter = Printer;
                    EditViewModel.EditView = view;
                    view.DataContext = EditViewModel;
                    view.ShowDialog();
                }
            );

            PrinterRepository = new FakeRepo();
            Printers = new ObservableCollection<Printer>(PrinterRepository.GetPrinters());
            

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
