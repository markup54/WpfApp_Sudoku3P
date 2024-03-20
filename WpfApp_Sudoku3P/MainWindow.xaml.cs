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

namespace WpfApp_Sudoku3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> Pola { get; set; } = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            for(int i = 0; i < 16; i++)
            {
                Pola.Add(1);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if(button.Content == null)
            {
                button.Content = "1";
            }
            else
            {
                string wart = button.Content.ToString();
                int ile = Int32.Parse(wart);
                if(ile == 4)
                {
                    ile = 1;
                }
                else
                {
                    ile++;
                }
                button.Content = ile.ToString();
            }
        }
    }
}
