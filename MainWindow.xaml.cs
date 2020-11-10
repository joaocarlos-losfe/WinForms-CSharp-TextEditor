using System;
using System.IO;
using System.Windows;
namespace Simple_note
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lbl_numero_dia_do_mes.Text = DateTime.Now.ToString("dd");
            lbl_nome_do_mes_abreviado.Text = DateTime.Now.ToString("MMM");
            lbl_ano.Text = DateTime.Now.ToString("yyyy");
            lbl_nome_do_dia_da_semana.Text = DateTime.Now.ToString("dddd");

            if( ! File.Exists("data.dat"))
            {
                File.Create("data.dat");
            }
            else
            {
                string[] dados = File.ReadAllLines("data.dat");

                foreach(var dado in dados)
                {
                    if(dado!= "" || dado != "\n")
                    {
                        listview.Items.Add(dado);
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            input_mensage_window input_window = new input_mensage_window();
            input_window.ShowDialog();

            if (input_window.mensage != null && input_window.mensage != "")
            {
                listview.Items.Add(DateTime.Now.ToString("g") + ": " + input_window.mensage);

                File.AppendAllText("data.dat", DateTime.Now.ToString("g") + ": " + input_window.mensage + "\n");

                input_window.mensage = null;
            }
                
        }
    }
}
