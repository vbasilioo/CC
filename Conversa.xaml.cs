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

namespace CC
{
    /// <summary>
    /// Lógica interna para Conversa.xaml
    /// </summary>
    public partial class Conversa : Window
    {

        private bool Maximizado = false;

        public Conversa()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount == 2)
            {
                if(Maximizado)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1250;
                    this.Height = 830;

                    Maximizado = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    Maximizado = true;
                }
            }
        }

        private void MenuButton_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow dashboard = new MainWindow();
            dashboard.Show();
            this.Hide();
        }
    }
}
