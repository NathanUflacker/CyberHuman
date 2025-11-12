using System.IO.Ports;
using System.Net;
using System.Security.Claims;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

using System;
namespace CyberHuman.Views
{
    public partial class WelcomeScreen : UserControl
    {
        public event Action OnStart;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            OnStart?.Invoke();
        }
    }
}
