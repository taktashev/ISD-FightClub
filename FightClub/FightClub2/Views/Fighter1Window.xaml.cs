using FightClub2.Interfaces;
using FightClub2.Models;
using FightClub2.Presenters;
using System;
using System.Windows;

namespace FightClub2.Views
{
    public partial class Fighter1Window : Window, IFighterWindow
    {
        public int FighterHp
        {
            set
            {
                if (value < 0)
                {
                    FighterHpTextBlock.Text = "0";
                    FighterHpProgressBar.Value = 0;
                }
                else
                {
                    FighterHpTextBlock.Text = value.ToString();
                    FighterHpProgressBar.Value = value;
                }
            }
        }

        public event EventHandler Fight;
        public event EventHandler Reload;

        public Fighter1Window(IFighter fighter)
        {
            InitializeComponent();

            #region Инициализация элементов интерфейса (уровень здоровья, имена бойцa)
            FighterHp = fighter.Hp;
            FighterNameTextBlock.Text = fighter.FighterName;
            #endregion

            MainWindows.FighterPresenter = new FighterPresenter(this, fighter);
        }

        #region Обработка нажатия кнопок окна
        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            Fight?.Invoke(sender, e);

            if (MainWindows.LogPresenter.LogWindow.Log.Contains("проиграл"))
            {
                BlockGroupBox.IsEnabled = false;
                HitGroupBox.IsEnabled = false;
                FightButton.IsEnabled = false;
                ReloadGameButton.Visibility = Visibility.Visible;
            }
        }
        private void ReloadGameButton_Click(object sender, RoutedEventArgs e)
        {
            BlockGroupBox.IsEnabled = true;
            HitGroupBox.IsEnabled = true;
            FightButton.IsEnabled = true;
            ReloadGameButton.IsEnabled = true;
            ReloadGameButton.Visibility = Visibility.Hidden;

            Reload?.Invoke(this, EventArgs.Empty);
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

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
        #endregion
    }
}
