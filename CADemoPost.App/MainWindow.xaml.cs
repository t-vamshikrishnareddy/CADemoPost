// ***********************************************************************
// Assembly         : CADemoPost.App
// Author           : TV
// Created          : 10-01-2016
//
// Last Modified By : TV
// Last Modified On : 10-02-2016
// ***********************************************************************
// <copyright file="MainWindow.xaml.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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
using CaDemoPost.VM;
using CADemoPost.App.Commands;
using CADemoPost.App.ViewModels;

namespace CADemoPost.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Gets or sets the main view model.
        /// </summary>
        /// <value>The main view model.</value>
        public MainViewModel MainViewModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel(this);
            this.DataContext = MainViewModel;
        }
    }
}
