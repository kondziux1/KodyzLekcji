
using System;
using Microsoft.Maui.Controls;

namespace PlazowaKosteczka
{
    public partial class MainPage : ContentPage
    {
        private int gameResult = 0;
        private readonly Random random = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            // Losowanie liczb dla pięciu kości
            int[] diceValues = new int[5];
            for (int i = 0; i < 5; i++)
            {
                diceValues[i] = random.Next(1, 7); // Liczby od 1 do 6
            }

            // Wyświetlenie obrazów dla wyników
            Die1.Source = $"n{diceValues[0]}.png";
            Die2.Source = $"n{diceValues[1]}.png";
            Die3.Source = $"n{diceValues[2]}.png";
            Die4.Source = $"n{diceValues[3]}.png";
            Die5.Source = $"n{diceValues[4]}.png";

            // Obliczanie sumy punktów
            int rollResult = CalculateRollResult(diceValues);
            gameResult += rollResult;

            // Aktualizacja etykiet
            RollResultLabel.Text = $"Wynik tego losowania: {rollResult}";
            GameResultLabel.Text = $"Wynik gry: {gameResult}";
        }

        private int CalculateRollResult(int[] diceValues)
        {
            // Przykładowy algorytm sumowania wyników
            int sum = 0;
            foreach (int value in diceValues)
            {
                sum += value;
            }
            return sum;
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            // Resetowanie wyników
            gameResult = 0;

            // Przywracanie obrazów pytajników
            Die1.Source = "question.jpg";
            Die2.Source = "question.jpg";
            Die3.Source = "question.jpg";
            Die4.Source = "question.jpg";
            Die5.Source = "question.jpg";

            // Aktualizacja etykiet
            RollResultLabel.Text = "Wynik tego losowania: 0";
            GameResultLabel.Text = "Wynik gry: 0";
        }
    }
}

