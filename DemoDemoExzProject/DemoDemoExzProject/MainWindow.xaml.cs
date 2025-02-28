using DemoDemoExzProject.Pages;
using System.Windows;

namespace DemoDemoExzProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.Initiaize(this);
            Navigation.NextPage(new MainPage());
        }
    }
}
