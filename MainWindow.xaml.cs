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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clean_UI
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.RightButton== MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_name.Text!=null && txtbox_email.Text!=null && txtbox_email.Text!=null && txtbox_age.Text!=null && rdbtn_male.IsChecked==true || rdbtn_female.IsChecked==true) 
            {
                ResourceManager rm = new ResourceManager("Clean_UI.Property.Language.Resource.submit_yes", Assembly.GetExecutingAssembly());
                MessageBox.Show(rm.GetString("Clean_UI.Property.Language.Resource"));
            }
            else
            {
                ResourceManager rm = new ResourceManager("Clean_UI.Property.Language.Resource.submit_yes", Assembly.GetExecutingAssembly());
                MessageBox.Show(rm.GetString("Clean_UI.Property.Language.Resource"));
            }
            else
            {
                MessageBox.Show("Enter all the details", "Register", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
