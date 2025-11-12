using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CyberHuman.Models;

namespace CyberHuman.Views
{
    public partial class Dashboard : UserControl
    {
        public event Action<Course> OnCourseSelected;
        public event Action OnBack;

        private List<Course> courses;

        public Dashboard()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            courses = new List<Course>
            {
                new Course("1", "Gestão de Projetos Digitais",
                    "Aprenda metodologias ágeis e gestão de projetos na era digital",
                    "8 semanas", "Intermediário", "Gestão", "💼", "#EC4899", "#FB7185"),

                new Course("2", "Programação para Iniciantes",
                    "Fundamentos de programação e lógica para começar sua jornada tech",
                    "10 semanas", "Iniciante", "Tecnologia", "💻", "#10B981", "#14B8A6"),

                new Course("3", "Design UX/UI",
                    "Crie experiências digitais intuitivas e acessíveis",
                    "6 semanas", "Intermediário", "Design", "🎨", "#A855F7", "#818CF8"),

                new Course("4", "Comunicação Digital",
                    "Marketing de conteúdo e estratégias de comunicação online",
                    "5 semanas", "Iniciante", "Marketing", "💬", "#F59E0B", "#FB923C"),

                new Course("5", "Análise de Dados",
                    "Transforme dados em insights valiosos para tomada de decisões",
                    "12 semanas", "Avançado", "Dados", "📊", "#3B82F6", "#06B6D4"),

                new Course("6", "Cibersegurança Básica",
                    "Proteja sistemas e dados no ambiente digital",
                    "7 semanas", "Intermediário", "Segurança", "🛡️", "#EF4444", "#EC4899")
            };

            CoursesItemsControl.ItemsSource = courses;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            OnBack?.Invoke();
        }

        private void CourseButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var course = button?.DataContext as Course;
            if (course != null)
            {
                OnCourseSelected?.Invoke(course);
            }
        }
    }
}