using System.Diagnostics.Tracing;
using System.Windows;

namespace MyDiaryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // This calls the auto-generated InitializeComponent method

        }

        /// make thewindow moveable
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            DragMove();
        }

        ///  minimize the window
        private void Minimize(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }
        ///  maximize the window
        private void Maximize(object sender, RoutedEventArgs e) {
            if(WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) {
            ///Close(); (close curretn window)
            Application.Current.Shutdown();
        }
        
    }
}
