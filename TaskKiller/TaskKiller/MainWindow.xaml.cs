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

namespace TaskKiller
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

        private void Button_KillByName(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /t /im " + textbox_byName.Text);
            textbox_byName.Focus();
        }
        private void Button_KillByID(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /pid " + textbox_byID.Text + " /f");
            textbox_byID.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Processes processes = new Processes();
            processes.Show();
        }
    }
}
