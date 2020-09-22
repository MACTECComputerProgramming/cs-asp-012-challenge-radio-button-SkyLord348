using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace CS_ASP_012CheckBoxChallange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {

            labelOutput.Content = "You must pick one!";



            if (radioButtonPencil.IsChecked == true)
            {

                labelOutput.Content = "Pencil! The old classic choice!";

                

                

            }
            
            if (radioButtonPen.IsChecked == true)
            {

                labelOutput.Content = "Pen! Great, reliable choice!";



            }

            if (radioButtonPhone.IsChecked == true)
            {

                labelOutput.Content = "Phone! Amazing, modern choice!";



            }

            if (radioButtonTablet.IsChecked == true)
            {

                labelOutput.Content = "Tablet! Interesting and futuristic choice!";





            }










        }
    }
}
