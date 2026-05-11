using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.IO;
using System.Text.RegularExpressions;

namespace API_KiluninaAA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init { get; set; }
        public List<classes.Groups> AllGroups = classes.Groups.AllGroups();
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(new pages.Groups());
        }
        public void OpenPages(Page page) =>
            frame.Navigate(page);
    }
}
