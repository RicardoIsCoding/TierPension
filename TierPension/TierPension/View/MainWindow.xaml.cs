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
using TierPension.VM;
using TierPension.Helper;

namespace TierPension
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var navigationService = new Helper.NavigationService(this);
            DataContext = new MainWindowViewModel(navigationService);
            this.Icon = new BitmapImage(new Uri("pack://application:,,,/Images/Icon.png"));
        }
    }
}
