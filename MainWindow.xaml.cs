using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
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

namespace SETTINGSUPDATE
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = txtname.Text;
            string Mail= txtmail.Text;
            string Phone=Convert.ToString(txtphone.Text);
            string Pass = pwdpass.Password;
            string Cpass=pwdcpass.Password;

            PROPERTY.Settings settings = new PROPERTY.Settings();
            settings.Name = txtname.Text;
            settings.Pass = pwdpass.Password.ToString();
            settings.Save();

            

            ResourceManager rm = new ResourceManager("SETTINGUPDATE.properties.language.Resource1", Assembly.GetExecutingAssembly());
            if ((txtname.Text!="") && (txtphone.Text!="") && (txtmail.Text!="") && (pwdpass.Password!="") && (pwdcpass.Password!=""))
            {
                Login ologin = new Login();
                ologin.Show();
            }

           

        }
    }
}
