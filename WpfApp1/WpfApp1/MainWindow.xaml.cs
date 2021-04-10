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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   


        private void firstButton_Click(object sender, RoutedEventArgs e)
        {
            var x = decimal.Parse(X.Text);
            var y = decimal.Parse(Y.Text);
            var r = decimal.Parse(R.Text);


            var cr = new QuadraticEquation(x,y,r);

            Result.Text = cr.Zapis;
        }
    }
}