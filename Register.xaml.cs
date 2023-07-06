using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name=txtname.Text;
            string pass = pwdpass.Password;

            PROPERTY.Settings settings = new PROPERTY.Settings();
            settings.Name = txtname.Text;
            settings.Pass = pwdpass.Password.ToString();
            settings.Save();

            ResourceManager rm = new ResourceManager("SETTINGSUPDATE.PROPERTY.Language.Resource", Assembly.GetExecutingAssembly());
            if ((txtname.Text !="") && (pwdpass.Password!="") && (pwdCpass.Password!=""))
            {
                MessageBox.Show(rm.GetString("update"),"WELCOME", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
