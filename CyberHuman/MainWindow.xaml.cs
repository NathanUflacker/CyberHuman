using System.Windows;
using System.Windows.Input;
using CyberHuman.Views;
using CyberHuman.Models;

namespace CyberHuman
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Permitir arrastar a janela
            this.MouseLeftButtonDown += (s, e) => { if (e.ButtonState == MouseButtonState.Pressed) this.DragMove(); };

            // Carregar tela inicial
            ShowWelcomeScreen();
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void ShowWelcomeScreen()
        {
            ContentArea.Children.Clear();
            var welcomeScreen = new WelcomeScreen();
            welcomeScreen.OnStart += ShowDashboard;
            ContentArea.Children.Add(welcomeScreen);
        }

        public void ShowDashboard()
        {
            ContentArea.Children.Clear();
            var dashboard = new Dashboard();
            dashboard.OnCourseSelected += ShowCourseDetails;
            dashboard.OnBack += ShowWelcomeScreen;
            ContentArea.Children.Add(dashboard);
        }

        public void ShowCourseDetails(Course course)
        {
            ContentArea.Children.Clear();
            var courseDetails = new CourseDetails(course);
            courseDetails.OnBack += ShowDashboard;
            ContentArea.Children.Add(courseDetails);
        }
    }
}