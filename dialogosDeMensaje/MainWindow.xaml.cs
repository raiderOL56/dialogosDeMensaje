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

namespace dialogosDeMensaje
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cliente = txt.Text;

            MessageBoxResult result = MessageBox.Show($"Bloqueará/Desbloqueará al cliente {cliente}, ¿Está de acuerdo?", "Advertencia", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Aceptaste", "My App");
                    break;
                case MessageBoxResult.No:
                    txt.Text = "";
                    break;
            }
        }
    }
}
