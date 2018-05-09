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
using UserService.Services;
using UserService = UserService.Services.UserServices;

namespace WpfAppWithWebApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IUserServices _userService = new UserServices();
        public MainWindow()
        {

            _userService.GetUsers();

            InitializeComponent();
        }
 
    }
}
