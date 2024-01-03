using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HRSoftware3000.Pages
{
    /// <summary>
    /// Interaktionslogik für ganttDiagrammPage.xaml
    /// </summary>
    public partial class ganttDiagrammPage : Window
    {
        public ganttDiagrammPage()
        {
            InitializeComponent();
            CreateGanttChart();

        }

        private void CreateGanttChart()
        {
            // Define the tasks
            List<Task> tasks = new List<Task>
            {
                new Task("Task 1", new DateTime(2024, 1, 3), new DateTime(2024, 1, 5)),
                new Task("Task 2", new DateTime(2024, 1, 6), new DateTime(2024, 1, 8)),
                new Task("Task 3", new DateTime(2024, 1, 9), new DateTime(2024, 1, 11)),
                new Task("Task 4", new DateTime(2024, 1, 12), new DateTime(2024, 1, 14)),
                new Task("Task 5", new DateTime(2024, 1, 15), new DateTime(2024, 1, 17))
            };

            // Create the chart
            GanttChart chart = new GanttChart(tasks);

            // Add the chart to the window
            this.Content = chart;
        }
    }

    public class Task
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Task(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }
    }

    public class GanttChart : Canvas
    {
        private List<Task> _tasks;

        public GanttChart(List<Task> tasks)
        {
            _tasks = tasks;
            Draw();
        }

        private void Draw()
        {
            // Define the colors
            Brush[] brushes = new Brush[]
            {
                Brushes.Red,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Purple
            };

            // Calculate the width of each task
            double totalDays = (_tasks.Max(t => t.EndDate) - _tasks.Min(t => t.StartDate)).TotalDays;
            double pixelsPerDay = this.ActualWidth / totalDays;

            // Draw each task
            for (int i = 0; i < _tasks.Count; i++)
            {
                Task task = _tasks[i];
                double x = (task.StartDate - _tasks.Min(t => t.StartDate)).TotalDays * pixelsPerDay;
                double width = (task.EndDate - task.StartDate).TotalDays * pixelsPerDay;
                double y = i * 50 + 10;
                double height = 30;

                Rectangle rect = new Rectangle
                {
                    Fill = brushes[i % brushes.Length],
                    Width = width,
                    Height = height,
                    Margin = new Thickness(x, y, 0, 0)
                };

                TextBlock text = new TextBlock
                {
                    Text = task.Name,
                    Margin = new Thickness(x + 5, y + 5, 0, 0)
                };

                this.Children.Add(rect);
                this.Children.Add(text);
            }
        }
    }
}
