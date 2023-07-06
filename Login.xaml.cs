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

namespace SETTINGSUPDATE
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtname.Text != "" && pwdpass.Password != "")
            {
                Register oregister = new Register();
                oregister.Show();
            }
            else
            {
                MessageBox.Show("Fill all the Details");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Register oregister = new Register();
            this.Close();
        }
    }
}
