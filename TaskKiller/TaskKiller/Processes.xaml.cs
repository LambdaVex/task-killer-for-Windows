using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace TaskKiller
{
    public class ViewModel
    {
        public List<ProcessInfo> Items
        {
            get
            {
                Process[] localAll = Process.GetProcesses();
                List<ProcessInfo> list = new List<ProcessInfo>();
                foreach (var item in localAll)
                {
                    list.Add(new ProcessInfo { Name = item.ProcessName, ID = item.Id });
                }
                return list;
            }
        }
    }
    public class ProcessInfo
    {

        public string Name { get; set; }
        public int ID { get; set; }
    }
    public partial class Processes : Window
    {
        public Processes()
        {
            DataContext = new ViewModel();
            InitializeComponent();
            this.Show();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
