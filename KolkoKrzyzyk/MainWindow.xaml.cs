using System;
using System.Collections.Generic;
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

namespace KolkoKrzyzyk
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private char actualPlayer = 'O';
        private bool A1Clickable = true;
        private bool A2Clickable = true;
        private bool A3Clickable = true;
        private bool B1Clickable = true;
        private bool B2Clickable = true;
        private bool B3Clickable = true;
        private bool C1Clickable = true;
        private bool C2Clickable = true;
        private bool C3Clickable = true;
        private int howManyMoves = 0;
        private char[,] table = new char[3, 3];
        
      


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = 'E';
                }
            }

            Info.Text = "Zaczynajmy! Pierwszy gracz: O";
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (A1Clickable)
            {
                table[0, 0] = actualPlayer;
                A1Clickable = false;
                A1.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (A2Clickable)
            {
                table[0, 1] = actualPlayer;
                A2Clickable = false;
                A2.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }


        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (A3Clickable)
            {
                table[0, 2] = actualPlayer;
                A3Clickable = false;
                A3.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (B1Clickable)
            {
                table[1, 0] = actualPlayer;
                B1Clickable = false;
                B1.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (B2Clickable)
            {
                table[1, 1] = actualPlayer;
                B2Clickable = false;
                B2.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (B3Clickable)
            {
                table[1, 2] = actualPlayer;
                B3Clickable = false;
                B3.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            if (C1Clickable)
            {
                table[2, 0] = actualPlayer;
                C1Clickable = false;
                C1.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (C2Clickable)
            {
                table[2, 1] = actualPlayer;
                C2Clickable = false;
                C2.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }

        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            if (C3Clickable)
            {
                table[2, 2] = actualPlayer;
                C3Clickable = false;
                C3.Content = Convert.ToString(actualPlayer);
                Button_Click();
            }

        }

        private void TheEnd()
        {
            if (IsItTheEnd())
            {
                A1Clickable = false;
                A2Clickable = false;
                A3Clickable = false;
                B1Clickable = false;
                B2Clickable = false;
                B3Clickable = false;
                C1Clickable = false;
                C2Clickable = false;
                C3Clickable = false;

                Info.Text = "Wygrywa " + Convert.ToString(actualPlayer);
            }

        }


        private void Button_Click()
        {
            TheEnd();

            if (IsItTheEnd() == false)
            {
                // Change player
                if (actualPlayer == 'O')
                {
                    actualPlayer = 'X';
                }
                else actualPlayer = 'O';

                howManyMoves++;


                if (howManyMoves >= 9)
                {
                    Info.Text = "Remis";
                }
                else
                {
                    Info.Text = "Runda gracza: " + Convert.ToString(actualPlayer);
                }

                
            }
        }



       


        // *****************************************************
        // ********** Sprawdzam warunek na koniec gry **********
        // *****************************************************

        private bool IsItTheEnd()
        {
            if (table[0, 0] == table[0, 1] && table[0, 1] == table[0, 2] && table[0, 0] == actualPlayer)
            {
                return true;
            }
            else if (table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2] && table[1, 0] == actualPlayer)
            {
                return true;
            }
            else if (table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2] && table[2, 0] == actualPlayer)
            {
                return true;
            }
            else if (table[0, 0] == table[1, 0] && table[1, 0] == table[2, 0] && table[0, 0] == actualPlayer)
            {
                return true;
            }
            else if (table[0, 1] == table[1, 1] && table[1, 1] == table[2, 1] && table[0, 1] == actualPlayer)
            {
                return true;
            }
            else if (table[0, 2] == table[1, 2] && table[1, 2] == table[2, 2] && table[0, 2] == actualPlayer)
            {
                return true;
            }
            else if (table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2] && table[0, 0] == actualPlayer)
            {
                return true;
            }
            else if (table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0] && table[0, 2] == actualPlayer)
            {
                return true;
            }
            else return false;

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = 'E';
                }
            }

            actualPlayer = 'O';

            A1Clickable = true;
            A2Clickable = true;
            A3Clickable = true;
            B1Clickable = true;
            B2Clickable = true;
            B3Clickable = true;
            C1Clickable = true;
            C2Clickable = true;
            C3Clickable = true;

            A1.Content = "";
            A2.Content = "";
            A3.Content = "";
            B1.Content = "";
            B2.Content = "";
            B3.Content = "";
            C1.Content = "";
            C2.Content = "";
            C3.Content = "";

            howManyMoves = 0;

            Info.Text = "Zaczynajmy! Pierwszy gracz: O";

        }
    }
}
