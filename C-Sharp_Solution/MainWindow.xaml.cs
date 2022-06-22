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

namespace C_Sharp_Solution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            customer customer = new customer();
            //ชื่อคลาส ชื่อตัวเเปร = new ชื่อคลาส();
            customer.Firstname = "สมชาย";
        }
        private void buttonshow_Click(object sender, RoutedEventArgs e)
        {
            customer customer1 = new customer();
            customer customer2 = new customer();
            customer1.Firstname = textboxFname.Text;
            customer1.Lastname = textboxLname.Text;
            MessageBox.Show("hello "+customer1.Firstname+" "+customer1.Lastname);

        }
    }
}
