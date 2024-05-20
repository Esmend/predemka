using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        demkaEntities db = new demkaEntities();
        public MainPage()
        {
            InitializeComponent();
            GetUser();
        }

        public void GetUser()
        {
            userGrid.ItemsSource = db.User.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string id_user = id_User.Text;
            string fio_user = fio_User.Text;
            string phone_user = phone_User.Text;
            string login_user = login_User.Text;
            string pass_user = pass_User.Text;
            string role_user = role.Text;
            if (!CheckTextBox())
            {
                return;
            }
            var user = new User(id_user, fio_user, phone_user, login_user, pass_user, role_user);
            db.User.Add(user);
            db.SaveChanges();
            GetUser();
            Clear();
        }

        public bool CheckTextBox()
        {
            string id_user = id_User.Text;
            string fio_user = fio_User.Text;
            string phone_user = phone_User.Text;
            string login_user = login_User.Text;
            string pass_user = pass_User.Text;
            string role_user = role.Text;
            if (!(id_user != "" && fio_user != "" && phone_user != "" && login_user != "" && pass_user != "" && role_user != ""))
            {
                MessageBox.Show("Не все поля были заполнены");
                return false;
            }
            return true;

        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var selected = userGrid.SelectedItem as User;
            if (selected != null)
            {
                db.User.Remove(selected);
                db.SaveChanges();
                GetUser();
            }
        }

        private void refreshBtn_Click(object sender, RoutedEventArgs e)
        {
            string id_user = id_User.Text;
            string fio_user = fio_User.Text;
            string phone_user = phone_User.Text;
            string login_user = login_User.Text;
            string pass_user = pass_User.Text;
            string role_user = role.Text;
            if (!CheckTextBox())
            {
                return;
            }
            
            var user = new User(id_user, fio_user, phone_user, login_user, pass_user, role_user);
            db.User.AddOrUpdate(user);
            db.SaveChanges();
            GetUser();
            Clear();
            
        }

        public void Clear()
        {
            id_User.Text = "";
            fio_User.Text = "";
            phone_User.Text = "";
            login_User.Text = "";
            pass_User.Text = "";
            role.Text = "";
        }

        private void userGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)userGrid.SelectedItem;
            id_User.Text = user.idUser.ToString();
            fio_User.Text = user.fioUser;
            phone_User.Text = user.phoneUser;
            login_User.Text = user.loginUser;
            pass_User.Text = user.passUser;
            role.Text = user.idRole.ToString();

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }       
}           
            
            