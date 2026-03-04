using System.Windows;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Pawdopt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Returning to home page");
        }

    }
}

