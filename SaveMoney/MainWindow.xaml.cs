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

namespace SaveMoney
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

        private void btncalculaate_Click(object sender, RoutedEventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            if ( textbox_income.Text !=""|| textbox_expense.Text!=""||textbox_needprice.Text!="")
            {
                double income = double.Parse(textbox_income.Text);
                double expense = double.Parse(textbox_expense.Text);
                double SaveMoney = income - expense;
                double needprice = double.Parse(textbox_needprice.Text);
                double calculateday = (needprice / SaveMoney);
                textbox_day.Text = calculateday.ToString();
            }
            else
            {
                MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง");
            }
        }
    }
}
