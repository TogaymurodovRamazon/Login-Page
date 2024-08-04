using Login.Class;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
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

        private void btn_signIn_Click(object sender, RoutedEventArgs e)
        {
            // imtilizatsiya qilish
            string email=tbox_email.Text;
            string password = pbox_password.Password;
            var date = DateTime.Now;
            // json qilib saqlash
            var ob = new User()
            {
                email = email,
                password = password,
                last_data = date
            };
            var json=JsonConvert.SerializeObject(ob);
            if (!Directory.Exists("Json"))
                Directory.CreateDirectory("Json");
            File.WriteAllText("Json/" + date.GetHashCode() + ".json", json);
            MessageBox.Show("Succesfulle!");
            tbox_email.Clear();
            pbox_password.Clear();

        }
    }
}