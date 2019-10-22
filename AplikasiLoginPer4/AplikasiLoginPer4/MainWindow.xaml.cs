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


        private string _username;
        private string _password;
        private string _checkUsername;
        private string _checkPassword;

        public string Username {
            get {
                return _username;
            }
            set {
                if (_username != value)
                {
                    _username = value;
                    if (_username == null || _username == "")
                    {
                        CheckUsername = "Username anda kosong";
                    }
                    else
                    {
                        CheckUsername = "";
                    }
                    OnPropertyChanged();

                }
            }
        }

        public string Password {
            get {
                return _password;
            }
            set {
                if (_password != value)
                {
                    _password = value;
                    if (_password == null || _password == "")
                    {
                        CheckPassword = "Password anda kosong";
                    }
                    else
                    {
                        CheckPassword = "";
                    }
                    OnPropertyChanged();

                }
            }
        }

        public string CheckUsername {
            get { return _checkUsername; }
            set {
                if(_checkUsername != value)
                {
                    _checkUsername = value;
                    OnPropertyChanged();
                }
            }
        }

        

        public string CheckPassword {
            get { return _checkPassword; }
            set {
                if (_checkPassword != value)
                {
                    _checkPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        // End Variabel

        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = this;
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
                MessageBox.Show("Username atau Password Salah ! ");
                txtUsername.Text = "";
                txtUsername.Focus();

            }
        }

    }
}
