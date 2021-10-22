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

namespace CuadrosTexto
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

        private void TextBox_KeyDownF1(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1)
            {
                this.TextoAyuda.Text = this.TextoAyuda.Text.Length == 0 ? "Ayuda." : "";
            }
        }
        private void TextBox_KeyDownF2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if(!int.TryParse(TextoEdad.Text,out _))
                {
                    this.TextoAyuda.Text = this.TextoAyuda.Text.Length == 0 ? "No es un número." : "";
                }
            }
        }
    }
}
