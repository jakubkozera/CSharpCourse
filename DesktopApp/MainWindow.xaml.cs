// ReSharper disable all
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Delay_Handler(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Start";

            await Task.Delay(3000);

            ResultLabel.Content = "Stop";


        }

        private void Read_Files_Handler(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Reading started:";
            var stopwatch = Stopwatch.StartNew();
            ProcessFiles();
            stopwatch.Stop();
            ResultLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms";

        }
        private async void Read_Files_Async_Handler(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Reading started:";
            var stopwatch = Stopwatch.StartNew();
            var result = await ProcessFilesAsync();
            stopwatch.Stop();
            ResultLabel.Content = $"Finished in: {stopwatch.ElapsedMilliseconds} ms. Result: {result}";

        }

        private async Task<int> ProcessFilesAsync()
        {
            var filesPath = "D:/files/";
            var totalLength = 0;
            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= 5; i++)
            {
                var filePath = filesPath + $"{i}.txt";

                var task = Task.Run(() =>
                {
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {

                        var fileContent = reader.ReadToEnd();


                        totalLength += fileContent.Length;
                        // processing file content..
                    }
                });

                tasks.Add(task);

            }

            await Task.WhenAll(tasks);
            
            return totalLength;
        }

        private void ProcessFiles()
        {
            var filesPath = "D:/files/";
            for (int i = 1; i <= 5; i++)
            {
                var filePath = filesPath + $"{i}.txt";

                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    ResultLabel.Content = $"Reading {filePath}..";

                    var fileContent = reader.ReadToEnd();

                    // processing file content..
                }
            }
        }
    }
}
