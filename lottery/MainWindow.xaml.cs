using System;
using System.Collections.Generic;
using System.Windows;

namespace lottery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitProgram();
        }

        void InitProgram()
        {
            config = LoadConfig();
            GenerateCandidate(config.Begin, config.End);
            Shuffle();
            ResultLabel.Content = candidates[0];
        }

        List<string> candidates = new List<string>();
        Config config;
        int currentIndex = 0;

        Config LoadConfig()
        {
            return new Config()
            {
                Begin = 10,
                End = 20
            };
        }

        void GenerateCandidate(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                candidates.Add(i.ToString());
            }
        }

        void Shuffle()
        {
            var randomizer = new Random();
            for (int i = candidates.Count - 2; i > 0; i--)
            {
                var randomIndex = randomizer.Next(i);
                var temp = candidates[i + 1];
                candidates[i + 1] = candidates[randomIndex];
                candidates[randomIndex] = temp;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentIndex++;
            if (currentIndex > candidates.Count - 1)
            {
                return;
            }
            ResultLabel.Content = candidates[currentIndex];
        }
    }
}
