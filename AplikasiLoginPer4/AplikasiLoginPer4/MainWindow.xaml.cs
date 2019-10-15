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

//      Using Library
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AplikasiLoginPer4.Views;
//

namespace AplikasiLoginPer4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        // All Variabel

        private WindowBaru _windowBaru;


        public string Username { get; set; } 
        public string Password { get; set; }
        // End Variabel

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;

            if (txtUsername.IsFocused)
            {
                txtUsername.Clear();
            }
        }

        /*
         *  
         * Binding Two Way
         */

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /*
         * END
         */

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(Username == "stevi" && Password == "amikom")
            {
                _windowBaru = new WindowBaru();
                _windowBaru.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Username);
                txtUsername.Text = "";
                txtUsername.Focus();

            }
        }
    }
}
