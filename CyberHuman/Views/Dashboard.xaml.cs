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
                new Course("1", "Gestor de Projetos Digitais e IA",
                    "Transforme-se de gerente tradicional em um líder de projetos digitais integrados à inteligência artificial e metodologias ágeis.",
                    "8 semanas", "Intermediário", "Gestão", "💼", "#EC4899", "#FB7185"),

                new Course("2", "Desenvolvedor de Soluções Inteligentes",
                    "De operador de sistemas a criador de aplicações inteligentes com fundamentos de programação e automação.",
                    "10 semanas", "Iniciante", "Tecnologia", "💻", "#10B981", "#14B8A6"),

                new Course("3", "Auditor de Experiência Digital (TI & UX)",
                    "Evolua de atendente para um auditor que analisa, testa e melhora interfaces e jornadas digitais com base em dados.",
                    "6 semanas", "Intermediário", "Design", "🎨", "#A855F7", "#818CF8"),

                new Course("4", "Estrategista de Comunicação e Mídias Digitais",
                    "De profissional de telemarketing a estrategista digital, planejando e otimizando conteúdos automatizados e inteligentes.",
                    "5 semanas", "Iniciante", "Marketing", "💬", "#F59E0B", "#FB923C"),

                new Course("5", "Analista de Dados e Decisão Estratégica",
                    "De assistente administrativo a analista de dados, transformando números em decisões inteligentes com ferramentas modernas.",
                    "12 semanas", "Avançado", "Dados", "📊", "#3B82F6", "#06B6D4"),

                new Course("6", "Especialista em Cibersegurança e Privacidade Digital",
                    "De técnico de suporte a guardião digital, protegendo informações e prevenindo ataques cibernéticos com práticas modernas de segurança.",
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