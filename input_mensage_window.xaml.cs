
using System.Windows;

namespace Simple_note
{
    /// <summary>
    /// Lógica interna para input_mensage_window.xaml
    /// </summary>
    public partial class input_mensage_window : Window
    {
        public string mensage = null;
        public input_mensage_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mensage = txtbox_mensage.Text;
            this.Close();
        }
    }
}
