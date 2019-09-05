using Aptude_KBX_WPF.Views;
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

namespace Aptude_KBX_WPF
{
    /// <summary>
    /// Lógica de interacción para W_Login.xaml
    /// </summary>
    public partial class W_Login : Window
    {
        public W_Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new W_Warehouse(Statics.ViewType.CREATE, new Aptude_KBX_MDL.Models.M_WareHouse()).ShowDialog();
        }
    }
}
