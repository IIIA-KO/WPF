using System;
using System.Windows;

namespace HW8
{
    public partial class MyColorDialog : Window
    {

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public MyColorDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Red = (int)RedSlider.Value;
                Green = (int)GreenSlider.Value;
                Blue = (int)BlueSlider.Value;

                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
