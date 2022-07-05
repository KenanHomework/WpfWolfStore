using System;
using System.Collections.Generic;
using System.IO;
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
using WpfWolfStore;
using WpfWolfStore.Model;
using WpfWolfStore.Services;

namespace WpfWolfStore.View
{
    /// <summary>
    /// Interaction logic for EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            Frame.Navigate(new LoginGeneralPage());
            UserService.WriteUser(new("kenan", "kenanYsbv", "kenanysbv@gmail.com"));
            //User user = UserService.ReadUser("kenan");
            //string a = user.ToString();
            //Store store = new(true);
            //User user = UserService.ReadUser("test");
            //store.SigIn(user);
            //store.Save();
            //store.Remember = true;
            //if (store.Remember)
            //{
            //    if (store.Login(user) == UserProcessResult.Success)
            //    {
            //        MessageBox.Show("Succes");
            //    }
            //}
        }

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {


            if (sender is Button btn)
            {
                switch (btn.Content.ToString())
                {
                    case "_":
                        Application.Current.MainWindow.WindowState = WindowState.Minimized;
                        break;
                    case "❒":
                        if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                            Application.Current.MainWindow.WindowState = WindowState.Normal;
                        else
                            Application.Current.MainWindow.WindowState = WindowState.Maximized;
                        break;
                    case "X":
                        Application.Current.Shutdown();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

    }
}
