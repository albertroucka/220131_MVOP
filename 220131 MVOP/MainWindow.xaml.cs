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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _220131_MVOP
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter File = null;
        //MyClass Class = new MyClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text == string.Empty || tb_surname.Text == string.Empty || tb_birthyear.Text == string.Empty || cb_education.SelectedItem.ToString() == string.Empty || tb_position.Text == string.Empty || tb_wage.Text == string.Empty)
            {
                MessageBox.Show("Nejsou vyplněna všechna pole!");
            }
            else
            {
                string education = cb_education.SelectedItem.ToString();

                Worker worker = new Worker()
                {
                    name = tb_name.Text,
                    surname = tb_surname.Text,
                    birthyear = Convert.ToInt32(tb_birthyear.Text),
                    education = education.Remove(0, 38),
                    position = tb_position.Text,
                    wage = Convert.ToDouble(tb_wage.Text)
                };

                File = new StreamWriter("Worker.txt");
                File.Write($@"Jméno: {worker.name} 
Přijmení: {worker.surname} 
Rok narození: {worker.birthyear}
Vzdělání: {worker.education}
Pozice: {worker.position}
Hrubá mzda: {worker.wage}");

                File.Close();
                tb_name.Text = string.Empty; tb_surname.Text = string.Empty; tb_birthyear.Text = string.Empty; 
                cb_education.SelectedItem = null; tb_position.Text = string.Empty; tb_wage.Text = string.Empty;
            }
        }
    }
}
