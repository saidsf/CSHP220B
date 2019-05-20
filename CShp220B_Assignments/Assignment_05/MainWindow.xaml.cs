using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Assignment_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        T3 t3Game;
        public MainWindow()
        {
            InitializeComponent();
            t3Game = new T3();
            uxTurn.Text = GameStatus.GameStatus_X_Trun.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!t3Game.IsGameOver())
            {
                Button tile = sender as Button;
                if (tile != null)
                {
                    string rowCol = tile.Tag.ToString();

                    GameStatus result = t3Game.MakeA_Move(rowCol, tile);
                    uxTurn.Text = result.ToString();
                    if (t3Game.IsGameOver())
                        uxGrid.IsEnabled = false;
                }
            }
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
    }
}
