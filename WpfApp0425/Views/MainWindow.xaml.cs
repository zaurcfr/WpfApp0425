﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp0425.Models;
using WpfApp0425.ViewModels;

namespace WpfApp0425
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Printer Printer { get; set; }
        //public MainWindow()
        //{
        //    this.DataContext = this;
        //    Printer = new Printer
        //    {
        //        Color = "Black",
        //        Model = "Envy",
        //        Vendor = "HP"
        //    };
        //    InitializeComponent();
        //}

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }



    }
}
