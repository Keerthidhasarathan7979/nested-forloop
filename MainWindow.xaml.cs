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

namespace nested_forloop
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
         
            int first = 0;
            int second = 1;
            stringBuilder.AppendLine(first.ToString());
            stringBuilder.AppendLine(second.ToString());
            //string print = first.ToString() + "," + second.ToString();
            for (int i=0;i<2;i++)
            {
                first = first + second;
                second = first + second;
                stringBuilder.AppendLine(first.ToString());
                stringBuilder.AppendLine(second.ToString());
                //print = print + first.ToString() + "," + second.ToString();
            }
            for (int i = 0; i < 3; i++)
            {
                first = first + second;
                second = first + second;
                stringBuilder.AppendLine(first.ToString());
                stringBuilder.AppendLine(second.ToString());
                //print = print + first.ToString() + "," + second.ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                first = first + second;
                second = first + second;
                stringBuilder.AppendLine(first.ToString());
                stringBuilder.AppendLine(second.ToString());
                //print = print + first.ToString() + "," + second.ToString();
            }
            for (int i = 0; i < 5; i++)
            {
                first = first + second;
                second = first + second;
                stringBuilder.AppendLine(first.ToString());
                stringBuilder.AppendLine(second.ToString());
                //print = print + first.ToString() + "," + second.ToString();
            }
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
