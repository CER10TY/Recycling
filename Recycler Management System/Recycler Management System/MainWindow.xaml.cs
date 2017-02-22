using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace Recycler_Management_System
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
            double recsNeeded = Math.Round(totalTF / RecStorage);
            lblMinText.Content = recsNeeded.ToString();
            lblRecText.Content = (recsNeeded + 5).ToString();
        }

        private void btnPaste_Click(object sender, RoutedEventArgs e)
        {
            string content = Clipboard.GetText();
            if (!Regex.IsMatch(content, @"^\d"))
            {
                Console.WriteLine("No match!");
                MessageBox.Show("Ressourcen konnten nicht eingefügt werden!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string[] splitContentWhole = content.Split('\n');

            foreach (string s in splitContentWhole)
            {
                string[] splitContent = s.Split(' ');
                string number = splitContent[0].Replace(".", string.Empty);
                string resource = splitContent[1].Trim();
                Console.WriteLine(number);
                Console.WriteLine(resource);
                switch (resource)
                {
                    case "Durastahl":
                        txtDuraAmount.Text = number;
                        break;
                    case "Tibannagas":
                        txtTibaAmount.Text = number;
                        break;
                    case "Kristall":
                        txtKrisAmount.Text = number;
                        break;
                    case "Energiezellen":
                        txtEZAmount.Text = number;
                        break;
                }
            }
        }
    }
}
