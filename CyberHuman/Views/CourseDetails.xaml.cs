using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CyberHuman.Models;

namespace CyberHuman.Views
{
    public partial class CourseDetails : UserControl
    {
        public event Action OnBack;
        private Course course;

        public CourseDetails(Course selectedCourse)
        {
            InitializeComponent();
            course = selectedCourse;
            LoadCourseDetails();
        }

        private void LoadCourseDetails()
        {
            TitleText.Text = course.Title;
            CategoryText.Text = course.Category;
            DescriptionText.Text = course.Description;
            DurationText.Text = course.Duration;
            LevelText.Text = course.Level;

            // Módulos do curso
            var modules = new List<string>
            {
                "Fundamentos e Introdução",
                "Conceitos Principais",
                "Prática Guiada",
                "Projeto Real",
                "Avaliação Final"
            };

            for (int i = 0; i < modules.Count; i++)
            {
                var modulePanel = CreateModulePanel(i + 1, modules[i]);
                ModulesPanel.Children.Add(modulePanel);
            }
        }

        private Border CreateModulePanel(int number, string title)
        {
            var border = new Border
            {
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33475569")),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(12),
                Margin = new Thickness(0, 0, 0, 12),
                Cursor = System.Windows.Input.Cursors.Hand
            };

            // Efeito hover
            border.MouseEnter += (s, e) => border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66475569"));
            border.MouseLeave += (s, e) => border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#33475569"));

            var grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            // Número do módulo
            var numberBorder = new Border
            {
                Width = 32,
                Height = 32,
                CornerRadius = new CornerRadius(8),
                Margin = new Thickness(0, 0, 12, 0)
            };

            var gradientBrush = new LinearGradientBrush();
            gradientBrush.StartPoint = new Point(0, 0);
            gradientBrush.EndPoint = new Point(1, 1);
            gradientBrush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#EC4899"), 0));
            gradientBrush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FB7185"), 1));
            numberBorder.Background = gradientBrush;

            var numberText = new TextBlock
            {
                Text = number.ToString(),
                Foreground = Brushes.White,
                FontSize = 14,
                FontWeight = FontWeights.SemiBold,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            numberBorder.Child = numberText;
            Grid.SetColumn(numberBorder, 0);

            // Título do módulo
            var titleText = new TextBlock
            {
                Text = title,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E2E8F0")),
                FontSize = 14,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(titleText, 1);

            // Ícone de check
            var checkText = new TextBlock
            {
                Text = "✓",
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#64748B")),
                FontSize = 18,
                VerticalAlignment = VerticalAlignment.Center
            };
            Grid.SetColumn(checkText, 2);

            grid.Children.Add(numberBorder);
            grid.Children.Add(titleText);
            grid.Children.Add(checkText);

            border.Child = grid;
            return border;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            OnBack?.Invoke();
        }

        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Inscrição realizada com sucesso no curso:\n{course.Title}",
                          "Sucesso",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
        }
    }
}