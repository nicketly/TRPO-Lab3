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
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.WPFA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Height.Text == "")
            {
                Height.Text = "Height";
            }

            if (Length.Text == "")
            {
                Length.Text = "Length";
            }

            if (Height.Text != "" && Length.Text != "")
            {
                var vm = new Params();
                DataContext = vm;
            }
            
        }

    }
}
