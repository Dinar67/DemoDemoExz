using System.Windows.Controls;

namespace DemoDemoExzProject
{
    public static class Navigation
    {
        public static MainWindow MainWindow { get; private set; }
        public static void Initiaize(MainWindow window)
        {
            MainWindow = window;
        }

        public static void NextPage(Page page)
        {
            if (MainWindow != null) MainWindow.MyFrame.Navigate(page);
        }
        public static void BackPage()
        {
            if (MainWindow != null && MainWindow.MyFrame.CanGoBack) MainWindow.MyFrame.GoBack();
        }
    }
}
