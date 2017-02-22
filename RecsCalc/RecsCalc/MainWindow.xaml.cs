using System.Windows;

namespace RecsCalc
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
        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
            double totalTF = int.Parse(txtDuraAmount.Text) + int.Parse(txtTibaAmount.Text) + int.Parse(txtKrisAmount.Text) + int.Parse(txtEZAmount.Text);
            double RecStorage = 17500;
            double recsNeeded = System.Math.Round(totalTF / RecStorage);
            lblMinText.Content = recsNeeded.ToString();
            lblRecText.Content = (recsNeeded + 5).ToString();
        }
    }
}
