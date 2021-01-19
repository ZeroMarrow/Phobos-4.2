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

namespace Phobos
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int[,] mas;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(NRow.Text);
                int m = int.Parse(NCol.Text);
                mas = new int[n, m];
                Random rnd = new Random();
                string st = "";
                for(int i = 0;i<n;i++)
                {
                    for(int j=0;j<m;j++)
                    {
                        mas[i, j] = rnd.Next(10);
                        st += mas[i, j] + "";
                    }
                    st += Environment.NewLine;
                }
                Result.Text = st;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string  S = "";
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    S += mas[i, j];
                }
                S += Environment.NewLine;
            }
            Result.Text = "" + S;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                   int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.GetUpperBound(1) + 1;
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}
