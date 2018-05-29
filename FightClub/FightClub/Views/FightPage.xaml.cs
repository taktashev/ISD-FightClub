using FightClub.Interfaces;
using FightClub.Presenters;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FightClub.Models
{
    public partial class FightPage : Page, IFightPage
    {
        public int Fighter1Hp
        {
            set
            {
                if (value < 0)
                {
                    Fighter1HpTextBlock.Text = "0"; 
                    Fighter1HpProgressBar.Value = 0;
                }
                else
                {
                    Fighter1HpTextBlock.Text = value.ToString();
                    Fighter1HpProgressBar.Value = value;
                }
            }
        }
        public int Fighter2Hp
        {
            set
            {
                if (value < 0)
                {
                    Fighter2HpTextBlock.Text = "0";
                    Fighter2HpProgressBar.Value = 0;
                }
                else
                {
                    Fighter2HpTextBlock.Text = value.ToString();
                    Fighter2HpProgressBar.Value = value;
                }
            }
        }
        
        public string Log
        {
            get { return LogTextBox.Text; }
            set { LogTextBox.AppendText(value); }
        }
        
        public event EventHandler Fight;
        public event EventHandler Reload;

        public FightPage(IFighter fighter1, IFighter fighter2)
        {
            InitializeComponent();

            #region Инициализация элементов интерфейса (уровень здоровья, имена бойцов)
            Fighter1Hp = fighter1.Hp;
            Fighter2Hp = fighter2.Hp;

            Fighter1NameTextBlock.Text = fighter1.FighterName;
            Fighter2NameTextBlock.Text = fighter2.FighterName;
            #endregion

            FightPresenter fightPresenter = new FightPresenter(this, fighter1, fighter2);

            #region Подписка на события страницы
            FightButton.Click += FightButton_Click;
            ReloadGameButton.Click += ReloadGameButton_Click;
            #endregion
        }

        #region Обработка нажатия кнопок страницы
        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            Fight?.Invoke(this, EventArgs.Empty);

            if (Log.Contains("проиграл"))
            {
                BlockGroupBox.IsEnabled = false;
                HitGroupBox.IsEnabled = false;
                FightButton.IsEnabled = false;
                ReloadGameButton.Visibility = Visibility.Visible;
            }
        }
        private void ReloadGameButton_Click(object sender, RoutedEventArgs e)
        {
            LogTextBox.Text = "";

            BlockGroupBox.IsEnabled = true;
            HitGroupBox.IsEnabled = true;
            FightButton.IsEnabled = true;
            ReloadGameButton.IsEnabled = true;
            ReloadGameButton.Visibility = Visibility.Hidden;

            Reload?.Invoke(this, EventArgs.Empty);
        }
        private void LogTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LogTextBox.Text.Length != 0)
                LogTextBox.ScrollToLine(LogTextBox.LineCount - 2);
        }
        #endregion

        /// <summary>
        /// Устанавливает бойцу блокируемую и атакуемую части тела в соответствии с выбранными RadioButon'ами на форме
        /// </summary>
        /// <param name="fighter">Боец, к которому применяются выбранные параметры</param>
        public void SetRoundSettings(IFighter fighter)
        {
            if (HitHeadRadioButton.IsChecked == true)
                fighter.Hit = PartOfTheBody.Head;
            if (HitBodyRadioButton.IsChecked == true)
                fighter.Hit = PartOfTheBody.Body;
            if (HitLegsRadioButton.IsChecked == true)
                fighter.Hit = PartOfTheBody.Legs;

            if (BlockHeadRadioButton.IsChecked == true)
                fighter.Blocked = PartOfTheBody.Head;
            if (BlockBodyRadioButton.IsChecked == true)
                fighter.Blocked = PartOfTheBody.Body;
            if (BlockLegsRadioButton.IsChecked == true)
                fighter.Blocked = PartOfTheBody.Legs;
        }
    }
}
