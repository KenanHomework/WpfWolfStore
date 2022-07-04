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
using WpfWolfStore.Interfaces;
using WpfWolfStore.Services;

namespace WpfWolfStore.View
{
    /// <summary>
    /// Interaction logic for LoginGeneralPage.xaml
    /// </summary>
    public partial class LoginGeneralPage : Page, IEnterPage
    {
        public LoginGeneralPage()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            RegxService.CheckControl(ref Username, 3, Color.FromRgb(27, 197, 188), "^([A-Za-z0-9]){4,20}$");
        }

        private void PasswordBox_Changed(object sender, RoutedEventArgs e)
        {
            RegxService.CheckControl(ref PasswordBox, 8, Color.FromRgb(27, 197, 188), "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");

        }

        public bool AllInfoCorrect()
        {
            return RegxService.CheckControl(ref PasswordBox, 8, Color.FromRgb(27, 197, 188), "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$") &&
                   RegxService.CheckControl(ref Username, 3, Color.FromRgb(27, 197, 188), "^([A-Za-z0-9]){4,20}$");
        }
    }
}
