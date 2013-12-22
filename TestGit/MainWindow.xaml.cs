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
using System.Runtime.InteropServices;

namespace TestGit
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("MathFuncsDll.dll", EntryPoint = "MyCalcAdd")]
        public extern static double MyCalcAdd(double a, double b);

        [DllImport("MathFuncsDll.dll", EntryPoint = "MyCalcSubtract")]
        public extern static double MyCalcSubtract(double a, double b);

        [DllImport("MathFuncsDll.dll", EntryPoint = "MyCalcMultiply")]
        public extern static double MyCalcMultiply(double a, double b);

        [DllImport("MathFuncsDll.dll", EntryPoint = "MyCalcDivide")]
        public extern static double MyCalcDivide(double a, double b); 



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = 100;
            double b = 50;

            Console.WriteLine("(a, b) =  (" + a + ", " + b + ")");
            Console.WriteLine("Add: " + MyCalcAdd(a, b));
            Console.WriteLine("Subtract: " + MyCalcSubtract(a, b));
            Console.WriteLine("Multiply: " + MyCalcMultiply(a, b));
            Console.WriteLine("Divide: " + MyCalcDivide(a, b));

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("CheckBox Clicked. ");
        }
    }
}
