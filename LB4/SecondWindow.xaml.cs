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
using System.Windows.Shapes;

namespace LB4
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void txtboxFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtboxFontSize.Text))
            {
                txtboxFontSize.Text = "1";
            }

            if (SliderFontSize != null && Message != null)
            {
                var size = Int32.Parse(txtboxFontSize.Text);
                SliderFontSize.Value = size;
                Message.FontSize = size;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var next = new SecondWindow();
            next.ShowDialog();
        }
    }
}
