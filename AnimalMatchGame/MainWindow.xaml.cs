using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;

namespace AnimalMatchGame
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            List<string> animals = new List<string>() {"🐵", "🐵", "🦝", "🦝", "🐷", "🐷", "🐸", "🐸", "🐲", "🐲", "🐔", "🐔", "🐰", "🐰", "🐗", "🐗"};
            Random rnd = new Random();
            foreach (TextBlock tb in mainGrid.Children.OfType<TextBlock>())
            {
                int id = rnd.Next(animals.Count);
                tb.Text = animals[id];
                animals.RemoveAt(id);
            }
        }
    }
}