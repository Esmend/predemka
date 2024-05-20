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

namespace predemka
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        demkaEntities db = new demkaEntities();
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = db.User.Where(d => (d.loginUser == login.Text && d.passUser == pass.Password)).FirstOrDefault();
            if (user != null )
            {
                MyFrame.frame.Navigate(new MainPage());
            }
            else
            {
                MessageBox.Show("ТЫ долбаёб!!!");
                login.Text = "";
                pass.Password = "";
            }
        }
    }
}
