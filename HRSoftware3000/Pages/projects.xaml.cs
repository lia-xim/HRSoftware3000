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

namespace HRSoftware3000.Pages
{
    /// <summary>
    /// Interaktionslogik für projects.xaml
    /// </summary>
    public partial class projects : Page
    {
        public projects()
        {
            InitializeComponent();
        }

        private void addProjectButton(object sender, RoutedEventArgs e)
        {
            Window window = new projectAddPage();
            window.Show();
        }

        private void ganttDiagramPage(object sender, RoutedEventArgs e)
        {
            Window window = new ganttDiagrammPage();
            window.Show();
        }
    }
}
